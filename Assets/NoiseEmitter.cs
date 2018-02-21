using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseEmitter : MonoBehaviour {

    public bool debug = false;

    void Update(){
        if(debug){
            debug = false;            
            SendNoise();
        }
    }

    public void SendNoise(){
        Spherecast();
    }

    void Spherecast(){
        float radius = 10;

		RaycastHit[] hits = new RaycastHit[5];

		Physics.SphereCastNonAlloc(transform.position, radius, transform.forward, hits, 0);



        foreach (RaycastHit hit in hits) {
            if(hit.collider){
                RaycastHit hit2;
                Physics.Raycast(transform.position, hit.transform.position - transform.position, out hit2, Mathf.Infinity);
                if(hit2.transform == hit.transform){
                    NoiseDetector nd = hit.collider.GetComponent<NoiseDetector>();

                    if(nd){
                        nd.AddNoice();
                    }
                }
            }
        }
        
	}
	
}
