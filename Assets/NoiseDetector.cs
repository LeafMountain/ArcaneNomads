using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NoiseDetector : MonoBehaviour {

	// public UnityEvent OnHear;

    // public void CheckObjects(GameObject[] gos){
    //     if(gos == null || gos.Length < 1){
    //         return;
    //     }

    //     foreach (GameObject go in gos) {
    //         if(go){
    //             NoiseEmitter ne = go.GetComponent<NoiseEmitter>();
    //             if(ne) {
    //                 Debug.Log("Detecting noise from " + go.name);
    //             }
    //         }
    //     }
    // }

    public void AddNoice(){
        Debug.Log("I heard a noise");
    }

}
