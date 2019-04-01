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

    const int TYPE = 0;
    const int LABEL = 1;
    const int NAME = 2;
    const int VARIATION = 3;

    public static AssetLabel[] Labels;
    public static string[] UnsortedFolders = { "Packages", "Assets/Editor", "Assets/Plugins", "Assets/3rd-Party", "Assets/Sandbox", "Assets/Scripts" };

    public static void CreateDefaultLabels()
    {
        Labels = new[] {
            new AssetLabel("Characters", "char"),
            new AssetLabel("Art", "art"),
            new AssetLabel("Scenes", "sce"),
            new AssetLabel("Placeables", "plac"),
<<<<<<< HEAD
            new AssetLabel("Audio", "audio"),
            new AssetLabel("MaterialLibrary", "matlib"),
            new AssetLabel("Environment", "env")
    };
=======
            new AssetLabel("Audio", "audio")
        };
>>>>>>> parent of 737efb13... Renaming some stuff
    }

    [MenuItem("Tools/Sort Project")]
    private static void SortAssets()
    {
        string[] assets = FindAssets("");
<<<<<<< HEAD
        // CreateFolderStructure("Sorted");
        // CreateFolderStructure("Unsorted");
=======
        CreateFolderStructure("Sorted");
        CreateFolderStructure("Unsorted");
>>>>>>> parent of 737efb13... Renaming some stuff
        CreateDefaultLabels();

        for (int i = 0; i < assets.Length; i++)
            SortFile(assets[i]);

        RemoveEmptyFolders("Assets");
    }

    private static void SortFile(string guid)
    {
        string filePath = AssetDatabase.GUIDToAssetPath(guid);
        string fileNameWithExtension = GetFileName(guid);

        // Check if it's a valid file in a valid location
        {
            // Check if it has an extension
            if (!fileNameWithExtension.Contains("."))
                return;

            // check if it's inside a Unsorted Folder
            bool unsortedFolder = false;
            for (int j = 0; j < UnsortedFolders.Length; j++)
            {
                if (filePath.Contains(UnsortedFolders[j]))
                {
                    unsortedFolder = true;
                    break;
                }
            }
            if (unsortedFolder) return;
        }

        // Remove file extension
        string fileName = fileNameWithExtension.Split('.')[0];
        string[] splitFileName = SplitName(fileName);

        // Check if file name is in a valid format
        if (splitFileName == null || !CheckIfValidFileName(fileName))
        {
            AssetDatabase.MoveAsset(filePath, "Assets/Unsorted/" + fileNameWithExtension);
            return;
        }

        Debug.Log("Sorting " + fileName);

        string name = splitFileName[NAME];
        string variation = splitFileName[VARIATION];
        string type = splitFileName[TYPE];
        string label = splitFileName[LABEL];
        label = GetFullLabelName(label);

        string newPath = label + "/" + name + "/" + variation;
        CreateFolderStructure(newPath);
        AssetDatabase.MoveAsset(filePath, "Assets/" + newPath + "/" + fileNameWithExtension);
    }

    private static string GetFullLabelName(string label)
    {
        foreach (AssetLabel assetLabel in Labels)
        {
            if (assetLabel.ShortLabel == label)
                return assetLabel.FullLabel;
        }

        return label;
        // return "Unsorted";
    }

    private static bool CheckIfValidFileName(string fileName)
    {
        // Remove file extension
        fileName = fileName.Split('.')[0];
        // Split into the different parts
        string[] splitFileName = SplitName(fileName);

        // Check if the length is correct
        if (splitFileName.Length < 4)
        {
            return false;
        }

        // Check if the label exists
        // if (GetFullLabelName(splitFileName[LABEL]) == "Unsorted")
        //     return false;

        return true;
    }

    private static string[] SplitName(string name)
    {
        return name.Split('_');
    }

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
            // reduce subfolders count if true
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
