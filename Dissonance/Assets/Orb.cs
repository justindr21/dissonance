using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour {
    public float movX;
    public float movY;

    void Start() {
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
    }

    void Update() {
        transform.position -= new Vector3(0.01f, 0f, 0f);
    }
}