using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class ArcaneBootstrap : MonoBehaviour
{
    public static ArcaneSettings Settings;

    public static void NewGame()
    {

    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void InitializeAfterSceneLoad()
    {
        var settingsGO = GameObject.Find("Settings");
        if (settingsGO == null)
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
            return;
        }

        InitializeWithScene();
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        InitializeWithScene();
    }

    public static void InitializeWithScene()
    {
        var settingsGO = GameObject.Find("Settings");
        Settings = settingsGO?.GetComponent<ArcaneSettings>();

        if (!Settings)
            return;

        // EnemySpawnSystem.SetupComponentData();
        

        // World.Active.GetOrCreateManager<UpdatePlayerHUD>().SetupGameObjects();

        // var sceneSwitcher = GameObject.Find("SceneSwitcher");
        // if (sceneSwitcher != null)
        // {
        //     NewGame();
        // }
    }
}
