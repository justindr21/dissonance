using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Hit");
    }
}