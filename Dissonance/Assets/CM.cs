using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM : MonoBehaviour
{

    public AudioSource Audio;

    public AudioClip Click;
    

    public static CM sfxInstance;
    
    private void Awake() {
        if (sfxInstance != null && sfxInstance != this) {
            Destroy(this.gameObject);
            return;
        }

        sfxInstance = this;
        DontDestroyOnLoad(this);    
    }


    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}