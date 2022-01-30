using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScript : MonoBehaviour
{

// Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if(Input.GetKey(KeyCode.Space)) {
            Vector3 offset = new Vector3(0.3f, 0, 0);
            transform.position += offset;
            Destroy(other.gameObject);
            Debug.Log("hit bar");
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
