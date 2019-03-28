using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[System.Serializable]
public struct AssetLabel
{
    public string FullLabel;
    public string ShortLabel;

    public AssetLabel(string FullLabel, string ShortLabel)
    {
        this.FullLabel = FullLabel;
        this.ShortLabel = ShortLabel;
    }
}

public class AssetManager
{
    // Template     = Name_Variation_type_label.suffix
    // PathTemplate = label/name/filename.suffix

    // Example1     = Bob_Evil_mat_char.mat
    // Example2     = Bob_Evil_tex_char.tga
    // Example3     = Bob_Evil_pref_char.prefab
    // Example3     = Bob_Normal_pref_char.prefab
    // PathExample1 = Character/Bob/Bob_Evil_mat_char.mats

    // file extensions
    const string PREFIXMESH = "mod_";
    const string SUFFIXMESH = ".fbx";

    const string PREFIXMATERIAL = "mat_";
    const string SUFFIXMATERIAL = ".mat";

    const string PREFXIPREFAB = "pref_";
    const string SUFFIXPREFAB = ".prefab";

    const string PREFIXTEXTURE = "tex_";
    const string SUFFIXTEXTURE = ".tga";

    const string CHARACTERTAG = "char_";

    const string SANDBOXPATH = "Assets/Sandbox";

    public static AssetLabel[] Labels;
    public string[] UnsortedFolders = { "Packages", "Assets/Editor", "Assets/Plugins" };

    public static void CreateDefaultLabels()
    {
        Labels = new[] {
            new AssetLabel("Characters", "char")
        };
    }

    [MenuItem("Tools/Sort Project")]
    private static void SortAssets()
    {
        string[] assets = FindAssets("");
        CreateFolderStructure("Sorted");
        CreateFolderStructure("Unsorted");
        CreateDefaultLabels();

        for (int i = 0; i < assets.Length; i++)
        {
            string guid = assets[i];
            string assetFileName = GetFileName(guid);

            if (assets[i].StartsWith("Assets/Sorted") || assets[i].Contains("Editor") || !assetFileName.Contains("."))
                continue;

            SortFile(AssetDatabase.GUIDToAssetPath(guid));


            // // Move to unsorted if file name is not valid
            // if (!CheckIfValidFileName(assetFileName))
            // {
            //     AssetDatabase.MoveAsset(AssetDatabase.GUIDToAssetPath(guid), "Assets/Unsorted/" + assetFileName);
            //     continue;
            // }

            // // Move to sorted if file name is valid
            // {
            //     string assetName = ExtractName(guid);
            //     string newAssetPath = "Sorted/" + assetName + "/" + assetFileName;

            //     // create new asset path
            //     CreateFolderStructure(newAssetPath);

            //     // move assets
            //     string oldPath = AssetDatabase.GUIDToAssetPath(guid);
            //     string result = AssetDatabase.MoveAsset(oldPath, "Assets/" + newAssetPath);

            //     if (result != "")
            //         Debug.Log(result);
            // }
        }

        RemoveEmptyFolders("Assets");
    }

    private static void SortFile(string path)
    {
        string fileName = GetFileName(path);
        string[] splitFileName = SplitName(fileName);

        // 0 = name
        // 1 = variation
        // 2 = type
        // 3 = label

        // Check if file name is in a valid format
        if (splitFileName == null || splitFileName.Length != 4)
        {
            AssetDatabase.MoveAsset(path, "Unsorted/" + fileName);
            return;
        }

        string name = splitFileName[0];
        string variation = splitFileName[1];
        string type = splitFileName[2];
        string label = splitFileName[3];

        CreateFolderStructure(label + "/" + name);
        AssetDatabase.MoveAsset(path, "Assets/" + label + "/" + name + "/" + fileName);
    }

    private static string GetFullLabelName(string label)
    {
        foreach (AssetLabel assetLabel in Labels)
        {
            if (assetLabel.ShortLabel == label)
                return assetLabel.FullLabel;
        }

        return "Unsorted";
    }

    private static bool CheckIfValidFileName(string fileName)
    {
        string[] splitFileName = fileName.Split('_');

        if (splitFileName.Length < 3)
            return false;

        return true;
    }

    private static string[] SplitName(string name)
    {
        string[] splitName = name.Split('_');
        return splitName.Length == 4 ? splitName : null;
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
    }

    // Recursively removes folders that are empty
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

    // private static void MoveFile(string oldPath, string newPath)
    // {
    //     CreateFolderStructure(newPath);
    // }
}
