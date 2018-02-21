using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseEmitter : MonoBehaviour {

    public bool debug = false;

    float lastRadius;

    void Update(){
        if(debug){
            debug = false;            
            SendNoise(10);
        }
    }

    public void SendNoise(float radius){
        lastRadius = radius;

        foreach (NoiseDetector detector in ExtractDetectors(CheckIfBlocked(ProximityCheck(radius)))) {
            detector.AddNoice(transform.position);
        }
    }

    List<NoiseDetector> ExtractDetectors(List<GameObject> targets){
        List<NoiseDetector> detectors = new List<NoiseDetector>();        

        for (int i = 0; i < targets.Count; i++)
        {
            NoiseDetector detector = targets[i].GetComponent<NoiseDetector>();

            if(detector){
                detectors.Add(detector);
            }
        }

        return detectors;
    }

    List<GameObject> CheckIfBlocked(List<GameObject> targets){
        RaycastHit hit2;

        for (int i = 0; i < targets.Count; i++)
        {
            Physics.Raycast(transform.position, targets[i].transform.position - transform.position, out hit2, Mathf.Infinity);

            if(hit2.transform != targets[i].transform){
                targets.Remove(targets[i]);
            }
        }
        
        return targets;
    }

    List<GameObject> ProximityCheck(float radius){
        int amountOfTargets = 10;
		RaycastHit[] hits = new RaycastHit[amountOfTargets];
        List<GameObject> targets = new List<GameObject>();

		Physics.SphereCastNonAlloc(transform.position, radius, transform.forward, hits, 0);

        for (int i = 0; i < amountOfTargets; i++)
        {
            if(hits[i].collider){
                targets.Add(hits[i].transform.gameObject);
            }
        }

        return targets;        
	}

    void OnDrawGizmos(){
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, lastRadius);
    }
	
}
