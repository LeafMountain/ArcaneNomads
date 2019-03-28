using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class AssetManager
{
    // Template = NAME_Variation?

    // file extensions
    const string PREFIXMESH = "mod_";
    const string SUFFIXMESH = ".fbx";

    const string PREFIXMATERIAL = "mat_";
    const string SUFFIXMATERIAL = ".mat";

    const string PREFXIPREFAB = "pref_";
    const string SUFFIXPREFAB = ".prefab";

    const string PREFIXTEXTURE = "tex_";
    const string SUFFIXTEXTURE = ".tga";

    [MenuItem("Tools/Sort Project")]
    private static void SortAssets()
    {
        FindAssets();
    }

    [MenuItem("Tools/Print Asset Paths")]
    private static void FindAssets()
    {


        // Material material = new Material(Shader.Find("Specular"));
        // CreateAsset(material, "__Test/Test.mat");
        // string guid = AssetDatabase.CreateFolder("Assets", "My Folder");
        // string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
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
                string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

                Debug.Log("Creating folder at " + currentPath + folder);
            }

            currentPath += "/" + folder;
        }
    }
}
