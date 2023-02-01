using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour{
    public AudioSource audioSource;
    
    void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
        PlayButton();
    }

    public void PlayButton(){
        audioSource.Play();
    }
}
