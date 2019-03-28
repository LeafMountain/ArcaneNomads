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
        string[] assets = FindAssets("mod_");
        CreateFolderStructure("Sorted");
        for (int i = 0; i < assets.Length; i++)
        {
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

        // RemoveEmptyFolders();
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
        return AssetDatabase.FindAssets(filter);
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
    private static void RemoveEmptyFolders()
    {
        string[] guids = AssetDatabase.GetAllAssetPaths();

        for (int i = 0; i < guids.Length; i++)
        {
            string path = guids[i];
            if (path.StartsWith("Assets/") && !path.Contains("."))
            {
                // AssetDatabase.FindAssets("")
                // check to see if the folder contain something
                Debug.Log(path + " " + path.Contains("."));
                AssetDatabase.DeleteAsset(path);
            }


            // if (!path.Contains("."))
            // {
            //     AssetDatabase.DeleteAsset(path);
            // }
        }
    }
}
