using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class AssetManager
{
    // Template = prefix_Name_Variation

    // file extensions
    const string PREFIXMESH = "mod_";
    const string SUFFIXMESH = ".fbx";

    const string PREFIXMATERIAL = "mat_";
    const string SUFFIXMATERIAL = ".mat";

    const string PREFXIPREFAB = "pref_";
    const string SUFFIXPREFAB = ".prefab";

    const string PREFIXTEXTURE = "tex_";
    const string SUFFIXTEXTURE = ".tga";

    const string SANDBOXPATH = "Assets/Sandbox";

    [MenuItem("Tools/Sort Project")]
    private static void SortAssets()
    {
        string[] assets = FindAssets("");
        CreateFolderStructure("Sorted");
        for (int i = 0; i < assets.Length; i++)
        {
            if (assets[i].StartsWith("Assets/Sorted"))
                continue;

            string guid = assets[i];
            string assetName = ExtractName(guid);
            string assetFileName = GetFileName(guid);
            string newAssetPath = "Sorted/" + assetName + "/" + assetFileName;

            // create new asset path
            CreateFolderStructure(newAssetPath);

            // move assets
            string oldPath = AssetDatabase.GUIDToAssetPath(guid);
            string result = AssetDatabase.MoveAsset(oldPath, "Assets/" + newAssetPath);

            if (result != "")
                Debug.Log(result);
        }

        RemoveEmptyFolders("Assets");
    }

    private static string ExtractPrefix(string guid)
    {
        string fileName = GetFileName(guid);
        string[] splitName = fileName.Split('_');
        return splitName[0];
    }

    private static string ExtractName(string guid)
    {
        string fileName = GetFileName(guid);
        string[] splitName = fileName.Split('_');
        return splitName[1];
    }

    // need to check if a variation exists
    private static string ExtractVariation(string guid)
    {
        string fileName = GetFileName(guid);
        string[] splitName = fileName.Split('_');
        return splitName[2];
    }
    // Need to check if a variation exists and pick index 2 instead
    private static string ExtractSuffix(string guid)
    {
        string fileName = GetFileName(guid);
        string[] splitName = fileName.Split('_');
        return splitName[3];
    }

    private static string GetFileName(string guid)
    {
        string path = AssetDatabase.GUIDToAssetPath(guid);
        string[] splitPath = path.Split('/');
        return splitPath[splitPath.Length - 1];
    }

    [MenuItem("Tools/Print Asset Paths")]
    private static string[] FindAssets(string filter)
    {
        return AssetDatabase.FindAssets(filter, new[] { "Assets" });
    }

    private static void CreateAsset(Object asset, string path)
    {
        // Create the asset path
        CreateFolderStructure(path);
        AssetDatabase.CreateAsset(asset, "Assets/" + path);
    }

    // Create path
    private static void CreateFolderStructure(string path)
    {
        string[] folders = path.Split('/');
        string currentPath = "Assets";

        foreach (string folder in folders)
        {
            if (!AssetDatabase.IsValidFolder(currentPath + "/" + folder) && !folder.Contains("."))
            {
                string guid = AssetDatabase.CreateFolder(currentPath, folder);
                Debug.Log("Creating folder at " + currentPath + "/" + folder);
            }

            currentPath += "/" + folder;
        }
    }

    [MenuItem("Tools/Remove Empty Folders")]
    private static void RemoveEmptyFolders2()
    {
        RemoveEmptyFolders("Assets");
        // string[] subFolders = AssetDatabase.GetSubFolders(path);
        // Debug.Log(subFolders[0]);
        // if (subFolders.Length == 0)
        // {
        //     AssetDatabase.DeleteAsset(path);
        // }

        // for (int i = 0; i < subFolders.Length; i++)
        // {
        //     RemoveEmptyFolders(path);
        // }
    }

    public static bool RemoveEmptyFolders(string path)
    {
        string[] subFolders = AssetDatabase.GetSubFolders(path);
        int subFoldersLength = subFolders.Length;
        // Debug.Log(path);

        for (int i = subFoldersLength - 1; i >= 0; i--)
        {
            // reduce subfolders if true
            if (RemoveEmptyFolders(subFolders[i]))
                subFoldersLength--;
        }

        bool containFiles = AssetDatabase.FindAssets("", new[] { path }).Length > 0;

        if (!containFiles && subFoldersLength == 0)
        {
            AssetDatabase.DeleteAsset(path);
            return true;
        }

        return false;
    }
}
