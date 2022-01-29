using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class OrbSpawner : MonoBehaviour
{
    public GameObject orb;
    public GameObject track1;
    public GameObject track2;
    public GameObject track3;
    public GameObject track4;
    public Vector3 test;
    public Vector3 test2;

    public void spawn(GameObject t) {
        Vector3 trackStart = t.transform.position + new Vector3(5,0,0);
        GameObject a = Instantiate(orb, trackStart, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
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
