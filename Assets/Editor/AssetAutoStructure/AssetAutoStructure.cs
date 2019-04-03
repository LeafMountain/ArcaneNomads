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
    // Template     = Name_Variation_type_label.suffix
    // PathTemplate = label/name/filename.suffix

    // Example1     = Bob_Evil_mat_char.mat
    // Example2     = Bob_Evil_tex_char.tga
    // Example3     = Bob_Evil_pref_char.prefab
    // Example3     = Bob_Normal_pref_char.prefab
    // PathExample1 = Character/Bob/Bob_Evil_mat_char.mats

    const int TYPE = 0;
    const int LABEL = 1;
    // const int NAME = 2;
    // const int VARIATION = 3;

    public static AssetLabel[] Labels;
    public static string[] UnsortedFolders = { "Packages", "Assets/Editor", "Assets/Plugins", "Assets/3rd-Party", "Assets/_Sandbox", "Assets/Scripts", "Assets/Maps" };

    public static bool AllowOnlyLabeled = true;
    public static int FolderLayers = 4;

    public static void CreateDefaultLabels()
    {
        Labels = new[] {
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
            new AssetLabel("Terrain", "terrain")
        };
    }

    [MenuItem("Tools/Sort Project")]
    private static void SortAssets()
    {
        string[] assets = FindAssetsNoFolders("");

        if (AllowOnlyLabeled)
            CreateFolderStructure("_Unsorted");

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
            // if (!fileNameWithExtension.Contains("."))
            //     return;

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
            AssetDatabase.MoveAsset(filePath, "Assets/_Unsorted/" + fileNameWithExtension);
            return;
        }

        // string label = splitFileName[LABEL];
        // label = GetFullLabelName(label);
        // int numberOfLayers = FolderLayers < splitFileName.Length ? FolderLayers : splitFileName.Length - 1;

        // for (int i = LABEL + 1; i < LABEL + numberOfLayers; i++)
        // {
        //     label += "/" + splitFileName[i];
        // }

        string newPath = GetFilePath(guid) + fileNameWithExtension;
        CreateFolderStructure(newPath);
        // Debug.Log(newPath);
        // AssetDatabase.MoveAsset(filePath, "Assets/" + newPath + "/" + fileNameWithExtension);
    }

    private static string GetFilePath(string guid)
    {
        string filePath = AssetDatabase.GUIDToAssetPath(guid);
        int fileNameIndex = filePath.LastIndexOf('/');
        string parentFolderPath = filePath.Remove(fileNameIndex, filePath.Length - fileNameIndex);
        string[] variations = GetVariations(guid);

        // Check variations and compare to the rest of the project
        string finalPath = variations[1];
        int previousMatchingAssetsCount = FindAssetsNoFolders(finalPath).Length;
        for (int i = 2; i < variations.Length - 1; i++)
        {
            string newFinalPath = finalPath + "_" + variations[i];

            string[] matchingAssets = FindAssetsNoFolders(newFinalPath);
            string[] nextLayer = FindAssetsNoFolders(newFinalPath + "_" + variations[i + 1]);

            if (matchingAssets.Length > nextLayer.Length)
            {
                previousMatchingAssetsCount = matchingAssets.Length;
                finalPath = newFinalPath;
            }
        }

        return parentFolderPath + "/";
    }

    private static string[] GetVariations(string guid)
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

        return AllowOnlyLabeled ? "Unsorted" : label;
    }

    private static bool CheckIfValidFileName(string fileName)
    {
        // Remove file extension
        fileName = fileName.Split('.')[0];
        // Split into the different parts
        string[] splitFileName = SplitName(fileName);

        // Check if the length is correct
        if (splitFileName.Length < 2)
        {
            return false;
        }

        // Check if the label exists
        if (GetFullLabelName(splitFileName[LABEL]) == "Unsorted")
            return false;

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
        return fileName;
    }

    [MenuItem("Tools/Print Asset Paths")]
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
            Debug.Log(isFolder);

            if (isFolder)
                filesOnly.Add(assets[i]);
        }

        return filesOnly.ToArray();
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
        string currentPath = "";

        for (int i = 0; i < folders.Length; i++)
        {
            string folder = folders[i];
            if (!AssetDatabase.IsValidFolder(currentPath + "/" + folder) && !folder.Contains("."))
            {
                string fixedFolder = char.ToUpper(folder[0]) + folder.Substring(1);
                AssetDatabase.CreateFolder(currentPath, fixedFolder);
                // Debug.Log("Creating folder at " + currentPath + "/" + fixedFolder);
            }

            currentPath += folder += "/";
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

    [MenuItem("Tools/Temp")]
    static void Temp()
    {
        string[] guids = AssetDatabase.FindAssets("env_sand", new[] { "Assets" });
        foreach (var guid in guids)
        {
            string oldPath = AssetDatabase.GUIDToAssetPath(guid);
            string[] oldPathSplit = oldPath.Split('/');
            string newPath = "";
            for (int i = 0; i < oldPathSplit.Length - 1; i++)
            {
                newPath += oldPathSplit[i] + "/";
            }

            string temp = oldPathSplit[oldPathSplit.Length - 1];
            string[] temp2 = temp.Split('_');

            newPath += temp2[0];
            newPath += "_env_nature";

            for (int i = 2; i < temp2.Length; i++)
            {
                newPath += "_";
                // if (temp2[i].Contains("building"))
                // {
                //     newPath += "city_";
                // }
                newPath += temp2[i];
            }

            // Debug.Log(oldPath + " to " + newPath);
            AssetDatabase.MoveAsset(oldPath, newPath);
        }
    }
}
