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
        int orbMax = 25;

            if (orbPool.Count < orbMax) {
            if (Input.GetKeyDown(KeyCode.Q)) {
        GM.sfxInstance.Audio.PlayOneShot(GM.sfxInstance.Click);

            spawn(track1);
        } else if (Input.GetKeyDown(KeyCode.W)) {
                    BbM.sfxInstance.Audio.PlayOneShot(BbM.sfxInstance.Click);

            spawn(track2);
        } else if (Input.GetKeyDown(KeyCode.E)) {
                    CM.sfxInstance.Audio.PlayOneShot(CM.sfxInstance.Click);

            spawn(track3);
        } else if (Input.GetKeyDown(KeyCode.R)) {
            spawn(track4);
            }
            
        }


        

    }
    
}
