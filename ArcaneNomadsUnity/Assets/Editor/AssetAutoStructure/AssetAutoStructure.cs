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

public class AssetAutoStructure
{
    const int TYPE = 0;
    const int LABEL = 1;

    const string UNSORTEDFOLDER = "_Unsorted";

    public static AssetLabel[] Labels = new[] {
        new AssetLabel("Characters", "char"),
        new AssetLabel("Placeables", "plac"),
        new AssetLabel("Audio", "audio"),
        new AssetLabel("MaterialLibrary", "matlib"),
        new AssetLabel("Environment", "env"),
        new AssetLabel("Effects", "vfx"),
        new AssetLabel("Effects", "fx"),
        new AssetLabel("Maps", "map"),
        new AssetLabel("Gear", "wpn"),
        new AssetLabel("Gear", "gear"),
        new AssetLabel("UI", "ui"),
        new AssetLabel("Audio", "sfx"),
        new AssetLabel("Terrain", "terrain"),
        new AssetLabel("Core", "core")
    };
    public static string[] UnsortedFolders = { 
        "Packages", 
        "Assets/Editor", 
        "Assets/Plugins", 
        "Assets/3rd-Party", 
        "Assets/_Sandbox", 
        "Assets/Scripts", 
        "Assets/Maps",
        "Assets/Settings"
    };

    public static bool AllowOnlyLabeled = true;

    // [MenuItem("Tools/Auto Structure/Sort Project")]
    public static void SortAssets()
    {
        string[] assets = FindAssetsNoFolders("");

        if (AllowOnlyLabeled)
            CreateFolderStructure(UNSORTEDFOLDER);

        for (int i = 0; i < assets.Length; i++)
            SortFile(assets[i]);

        RemoveEmptyFolders("Assets");
    }

    public static void SortFile(string guid)
    {
        string filePath = AssetDatabase.GUIDToAssetPath(guid);
        string fileNameWithExtension = GetFileName(guid);

        // Check if it's a valid file in a valid location
        {
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

        string newPath = ConstructFilePath(guid);
        CreateFolderStructure(newPath);
        string newCompletePath = "Assets/" + newPath + "/" + fileNameWithExtension;
        if(filePath != newCompletePath)
            Debug.Log(AssetDatabase.MoveAsset(filePath, newCompletePath));
    }

    private static string ConstructFilePath(string guid)
    {
        string filePath = AssetDatabase.GUIDToAssetPath(guid);
        int fileNameIndex = filePath.LastIndexOf('/');
        string parentFolderPath = filePath.Remove(fileNameIndex, filePath.Length - fileNameIndex);
        string[] tags = GetTags(guid);

        if(tags.Length < 2)
            return UNSORTEDFOLDER;

        // Start with the first tag
        string currentFileName = tags[1];
        // Start with the first tag
        string finalPath = GetFullLabelName(tags[1]);
        int previousMatchingAssetsCount = FindAssetsNoFolders(currentFileName).Length;

        for (int i = 2; i < tags.Length; i++)
        {
            // Add the new tag
            currentFileName += "_" + tags[i];

            // Get all the assets with matching tags
            string[] currentLayer = FindAssetsNoFolders(currentFileName);

            if(currentLayer.Length == 1)
                break;

            // If the next layer has fewer hits, create a folder to gather the variations under
            if (previousMatchingAssetsCount > currentLayer.Length)
            {
                finalPath += "/" + tags[i];
                previousMatchingAssetsCount = currentLayer.Length;
            }
        }

        return finalPath;
    }

    private static string[] GetTags(string guid)
    {
        string fileName = GetFileName(guid);
        fileName = fileName.Split('.')[0];
        return fileName.Split('_');
    }

    private static string GetFullLabelName(string label)
    {
        foreach (AssetLabel assetLabel in Labels)
        {
            if (assetLabel.ShortLabel == label)
                return assetLabel.FullLabel;
        }

        return AllowOnlyLabeled ? UNSORTEDFOLDER : label;
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
        return fileName;
    }

    private static string[] FindAssets(string filter)
    {
        return AssetDatabase.FindAssets(filter, new[] { "Assets" });
    }

    private static string[] FindAssetsNoFolders(string filter)
    {
        string[] assets = AssetDatabase.FindAssets(filter, new[] { "Assets" });
        List<string> filesOnly = new List<string>();

        for (int i = assets.Length - 1; i >= 0; i--)
        {
            bool isFolder = AssetDatabase.IsValidFolder(AssetDatabase.GUIDToAssetPath(assets[i]));

            if (!isFolder)
                filesOnly.Add(assets[i]);
        }

        return filesOnly.ToArray();
    }

    private static string MoveAsset(string oldPath, string newPath)
    {
        CreateFolderStructure(newPath);
        return AssetDatabase.MoveAsset(oldPath, "Assets/" + newPath);
    }

    // Create path
    private static void CreateFolderStructure(string path)
    {
        string[] folders = path.Split('/');
        string currentPath = "Assets";

        for (int i = 0; i < folders.Length; i++)
        {
            string folder = folders[i];

            if (!AssetDatabase.IsValidFolder(currentPath + "/" + folder))
            {
                // Make first letter uppercase
                string fixedFolder = char.ToUpper(folder[0]) + folder.Substring(1);
                AssetDatabase.CreateFolder(currentPath, fixedFolder);
            }

            currentPath += "/" + folder;
        }
    }

    // [MenuItem("Tools/Auto Structure/Remove Empty Folders")]
    private static void RemoveEmptyFoldersEditorShortcut()
    {
        RemoveEmptyFolders("Assets");
    }

    // Recursively removes folders that are empty
    public static bool RemoveEmptyFolders(string path)
    {
        string[] subFolders = AssetDatabase.GetSubFolders(path);
        int subFoldersLength = subFolders.Length;

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
