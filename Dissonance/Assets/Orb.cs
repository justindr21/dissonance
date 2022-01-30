using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour {

    void Start() {
    }

    void Update() {
        transform.position -= new Vector3(0.015f, 0f, 0f);
    }
}