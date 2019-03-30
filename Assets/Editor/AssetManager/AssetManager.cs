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

    const int NAME = 0;
    const int VARIATION = 1;
    const int TYPE = 2;
    const int LABEL = 3;

    // file extensions
    // const string PREFIXMESH = "mod_";
    // const string SUFFIXMESH = ".fbx";

    // const string PREFIXMATERIAL = "mat_";
    // const string SUFFIXMATERIAL = ".mat";

    // const string PREFXIPREFAB = "pref_";
    // const string SUFFIXPREFAB = ".prefab";

    // const string PREFIXTEXTURE = "tex_";
    // const string SUFFIXTEXTURE = ".tga";

    // const string CHARACTERTAG = "char_";

    // const string SANDBOXPATH = "Assets/Sandbox";

    public static AssetLabel[] Labels;
    public static string[] UnsortedFolders = { "Packages", "Assets/Editor", "Assets/Plugins", "Assets/3rd-Party", "Assets/Sandbox" };

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

            bool unsortedFolder = false;
            // check if it's inside a Unsorted Folder
            for (int j = 0; j < UnsortedFolders.Length; j++)
            {
                if (assetFileName.Contains(UnsortedFolders[j]))
                {
                    unsortedFolder = true;
                    break;
                }
            }

            if (unsortedFolder || !assetFileName.Contains("."))
                continue;

            SortFile(guid);

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

        // RemoveEmptyFolders("Assets");
    }

    private static void SortFile(string guid)
    {
        string filePath = AssetDatabase.GUIDToAssetPath(guid);
        string fileName = GetFileName(guid);
        // Remove file extension
        fileName = fileName.Split('.')[0];

        string[] splitFileName = SplitName(fileName);

        // Check if file name is in a valid format
        if (splitFileName == null || !CheckIfValidFileName(fileName))
        {
            AssetDatabase.MoveAsset(guid, "Unsorted/" + fileName);
            return;
        }

        Debug.Log("Sorting " + fileName);

        string name = splitFileName[NAME];
        string variation = splitFileName[VARIATION];
        string type = splitFileName[TYPE];
        string label = splitFileName[LABEL];

        CreateFolderStructure("Sorted/" + label + "/" + name);
        Debug.Log(AssetDatabase.MoveAsset(filePath, "Assets/Sorted/" + label + "/" + name + "/" + fileName));
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
        // Remove file extension
        fileName = fileName.Split('.')[0];
        // Split into the different parts
        string[] splitFileName = SplitName(fileName);

        // Check if the length is correct
        if (splitFileName.Length != 4)
            return false;

        // Check if the label exists
        if (GetFullLabelName(splitFileName[LABEL]) == "Unsorted")
            return false;

        return true;
    }

    private static string[] SplitName(string name)
    {
        return name.Split('_');
    }

    // private static string ExtractType(string guid)
    // {
    //     string fileName = GetFileName(guid);
    //     string[] splitName = fileName.Split('_');
    //     return splitName[TYPE];
    // }

    // private static string ExtractName(string guid)
    // {
    //     string fileName = GetFileName(guid);
    //     string[] splitName = fileName.Split('_');
    //     return splitName[NAME];
    // }

    // // need to check if a variation exists
    // private static string ExtractVariation(string guid)
    // {
    //     string fileName = GetFileName(guid);
    //     string[] splitName = fileName.Split('_');
    //     return splitName[VARIATION];
    // }
    // // Need to check if a variation exists and pick index 2 instead
    // private static string ExtractSuffix(string guid)
    // {
    //     string fileName = GetFileName(guid);
    //     string[] splitName = fileName.Split('_');
    //     return splitName[splitName.Length - 1].Split('.')[0];
    // }

    private static string GetFileName(string guid)
    {
        string path = AssetDatabase.GUIDToAssetPath(guid);
        string[] splitPath = path.Split('/');
        string fileName = splitPath[splitPath.Length - 1];
        // string[] splitSuffix = fileName.Split('.');
        // Debug.Log(fileName + " " + splitSuffix.Length);
        return fileName;
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
    private static void RemoveEmptyFoldersEditorShortcut()
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
}
