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
        // movX = 0f;
        // movY = 0f;

        // if(Input.GetKey(KeyCode.UpArrow)) {
        //     movY = +0.01f;
        // } else if (Input.GetKey(KeyCode.DownArrow)) {
        //     movY = -0.01f;
        // } else if (Input.GetKey(KeyCode.RightArrow)) {
        //     movX = +0.01f;
        // } else if (Input.GetKey(KeyCode.LeftArrow)) {
        //     movX = -0.01f;
        // }

        // Vector3 moveDir = new Vector3(movX, movY).normalized;
        // transform.position += moveDir * 1.0f * Time.deltaTime;
    }
}