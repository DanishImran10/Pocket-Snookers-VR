using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour
{
    float bounciness = 0.9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag.StartsWith("Balls"))
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            Vector3 normal = other.contacts[0].normal;
            Vector3 reflection = Vector3.Reflect(rb.velocity, normal);
            rb.velocity = reflection * bounciness;
        }
    }
}
