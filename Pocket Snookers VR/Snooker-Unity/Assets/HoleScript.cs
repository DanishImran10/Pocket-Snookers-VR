using System.Collections;
using System.Collections.Generic;
//using UnityEditor.UI;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public GameObject GM;
    public AudioSource audioSource;
    public AudioClip[] clips;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.name.StartsWith("CueBall"))
        {
            GM.GetComponent<GameManagerScript>().displayText.text = "Foul!";
            GM.GetComponent<GameManagerScript>().score -= 2;
            audioSource.clip = clips[0]; //foul
            audioSource.Play();

            GM.GetComponent<GameManagerScript>().isfoul = true;
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

        if(other.gameObject.name.StartsWith("Red"))
        {
            GM.GetComponent<GameManagerScript>().displayText.text = "Red Potted!";
            GM.GetComponent<GameManagerScript>().score += 1;
            audioSource.clip = clips[1]; //potted
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if(other.gameObject.name.StartsWith("Yellow"))
        {
            GM.GetComponent<GameManagerScript>().displayText.text = "Yellow Potted!";
            GM.GetComponent<GameManagerScript>().score += 2;
            audioSource.clip = clips[1]; //potted
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if(other.gameObject.name.StartsWith("Green"))
        {
            GM.GetComponent<GameManagerScript>().displayText.text = "Green Potted!";
            GM.GetComponent<GameManagerScript>().score += 3;
            audioSource.clip = clips[1]; //potted
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if(other.gameObject.name.StartsWith("Brown"))
        {
            GM.GetComponent<GameManagerScript>().displayText.text = "Brown Potted!";
            GM.GetComponent<GameManagerScript>().score += 4;
            audioSource.clip = clips[1]; //potted
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if(other.gameObject.name.StartsWith("Blue"))
        {
            GM.GetComponent<GameManagerScript>().displayText.text = "Blue Potted!";
            GM.GetComponent<GameManagerScript>().score += 5;
            audioSource.clip = clips[1]; //potted
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if(other.gameObject.name.StartsWith("Pink"))
        {
            GM.GetComponent<GameManagerScript>().displayText.text = "Pink Potted!";
            GM.GetComponent<GameManagerScript>().score += 6;
            audioSource.clip = clips[1]; //potted
            audioSource.Play();
            Destroy(other.gameObject);
        }

        if(other.gameObject.name.StartsWith("Black"))
        {
            GM.GetComponent<GameManagerScript>().displayText.text = "Black Potted!";
            GM.GetComponent<GameManagerScript>().score += 7;
            audioSource.clip = clips[1]; //potted
            audioSource.Play();
            Destroy(other.gameObject);
        }
    }
}
