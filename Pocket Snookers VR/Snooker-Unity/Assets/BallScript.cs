using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] clips;
    private static bool HasPlayed;
    // Start is called before the first frame update
    void Start()
    {
        HasPlayed = false;
    }

    // Update is called once per frame
    private void LateUpdate() 
    {
        HasPlayed = false;   
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Balls" && !HasPlayed)
        {
            HasPlayed = true;
            audioSource.clip = clips[0]; //balls collision
            audioSource.Play();
        }
        
        if (other.gameObject.name.StartsWith("Border"))
        {
            audioSource.clip = clips[1]; //border collision
            audioSource.Play();
        }
    }
}
