using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class OrbSpawner : MonoBehaviour
{
    public GameObject orb;
    public GameObject bar;
    public List<GameObject> orbPool;
    public GameObject track1;
    public GameObject track2;
    public GameObject track3;
    public GameObject track4;
    public Vector3 orbPosTest;
    public Vector3 barPos;

    public void spawn(GameObject t) {
        float trackStartY = t.transform.position.y;
        orbPool.Add(Instantiate(orb, new Vector3(5f, trackStartY, 0), Quaternion.identity));
    }

    // Update is called once per frame
    void Update()
    {
        int orbMax = 10;

        if (orbPool.Count < orbMax) {
            if (orbPool.Count < 10) {
            if (Input.GetKeyDown(KeyCode.Q)) {
            spawn(track1);
            audioSource.PlayOneShot(P2Bass);
        } else if (Input.GetKeyDown(KeyCode.W)) {
            spawn(track2);
            audioSource.PlayOneShot(P2Chords);
        } else if (Input.GetKeyDown(KeyCode.E)) {
            spawn(track3);
            audioSource.PlayOneShot(P2Drum);
        } else if (Input.GetKeyDown(KeyCode.R)) {
            spawn(track4);
            audioSource.PlayOneShot(P2Lead);
            }
            }
        }


        

    }
    
}
