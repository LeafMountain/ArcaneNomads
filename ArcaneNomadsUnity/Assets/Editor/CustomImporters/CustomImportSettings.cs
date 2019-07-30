using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// Set the scale of all the imported models to  "globalScaleModifier"
// and dont generate materials for the imported objects

public class CustomImportSettings : AssetPostprocessor
{
    float globalScaleModifier  = 1f;

    void OnPreprocessModel()
    {
        ModelImporter importer = (ModelImporter)assetImporter;
        importer.globalScale = globalScaleModifier;
        importer.importMaterials = false;
    }

    // void OnPreprocessTexture()
    // {
    //     Debug.Log("Importing texture to: " + assetPath);
    //     TextureImporter importer  = (TextureImporter)assetImporter;
    //     importer.textureFormat = TextureImporterFormat.ARGB32;
    //     importer.isReadable = true;
    //     importer.mipmapEnabled = false;

    //     // if(importer.name.Split('_')[0] != tex
    // }

}