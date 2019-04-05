using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

class AssetAutoStructureImportScript : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        // foreach (string str in importedAssets)
        // {
        //     Debug.Log("Reimported Asset: " + str);
        //     // AssetAutoStructure.SortFile(AssetDatabase.AssetPathToGUID(str));
        // }
        // foreach (string str in deletedAssets)
        // {
        //     Debug.Log("Deleted Asset: " + str);
        // }

        // for (int i = 0; i < movedAssets.Length; i++)
        // {
        //     Debug.Log("Moved Asset: " + movedAssets[i] + " from: " + movedFromAssetPaths[i]);
        // }

        // AssetAutoStructure.SortAssets();

        // assetPath = "Assets/Test/" + assetPath.Split('/')[0];
        // Debug.Log("assetPath");
        // AssetAutoStructure.SortFile(AssetDatabase.AssetPathToGUID(assetImporter.assetPath));
        
    }
}