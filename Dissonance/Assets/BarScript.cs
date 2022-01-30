using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScript : MonoBehaviour
{
    // Start is called before the first frame update


// Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if(Input.GetKey(KeyCode.Space)) {
            Vector3 offset = new Vector3(0.25f, 0, 0);
            transform.position += offset;
            Destroy(other.gameObject);
            Debug.Log("hit");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
