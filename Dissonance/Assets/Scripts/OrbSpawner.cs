using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class OrbSpawner : MonoBehaviour
{
    public GameObject orb;
    public List<GameObject> orbPool;
    public GameObject track1;
    public GameObject track2;
    public GameObject track3;
    public GameObject track4;
    public Vector3 orbPosTest;

    public void spawn(GameObject t) {
        float trackStartY = t.transform.position.y;
        orbPool.Add(Instantiate(orb, new Vector3(5f, trackStartY, 0), Quaternion.identity));
        orbPosTest = orbPool[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        int orbMax = 10;

        if (orbPool.Count < orbMax) {
            if (orbPool.Count < 10) {
            if (Input.GetKeyDown(KeyCode.Q)) {
            spawn(track1);
        } else if (Input.GetKeyDown(KeyCode.W)) {
            spawn(track2);
        } else if (Input.GetKeyDown(KeyCode.E)) {
            spawn(track3);
        } else if (Input.GetKeyDown(KeyCode.R)) {
            spawn(track4);
            }
            }
        }
        foreach(GameObject g in orbPool)
            {
                if (g.transform.position.x > -5f) {
                    g.transform.position -= new Vector3(0.01f, 0f, 0f);
                }
            }
    }
}
