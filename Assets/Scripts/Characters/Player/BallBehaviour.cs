using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
   public float velocityFactor;// only applies to gravity for now
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,-9.8f*velocityFactor,0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("player collision");
        }
        if (collision.gameObject.CompareTag("Bullets"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            print("shot");
        }

    }

}
