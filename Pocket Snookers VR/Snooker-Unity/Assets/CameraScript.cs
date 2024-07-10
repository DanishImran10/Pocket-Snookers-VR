using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject cue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableCamera()
    {
        enabled = true;
        print("en");
    }

    public void DisableCamera()
    {
        enabled = false;
        print("dis");
    }
}
