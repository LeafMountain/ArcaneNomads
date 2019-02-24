using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSystem : MonoBehaviour
{
    private static MessageSystem Instance;

    void Awake()
    {
        if(Instance)
            DestroyImmediate(this);
        else
            Instance = this;
    }

    public static void Send()
    {
        // Send a message
    }

    public static void Subscribe()
    {
        // Add object to subscriber list
    }
}
