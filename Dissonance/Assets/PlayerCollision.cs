using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject bar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Vector3 offset = new Vector3(0.3f, 0, 0);
        bar.transform.position -= offset;
        Destroy(other.gameObject);
        Debug.Log("hit player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
