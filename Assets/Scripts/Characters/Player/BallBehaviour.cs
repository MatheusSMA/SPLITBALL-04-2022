using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    [SerializeField] private float velocityFactor;// only applies to gravity for now
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(-1, -9.8f * velocityFactor, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("player collision");
        }
        if (other.gameObject.CompareTag("Bullets"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            print("shot");
        }

    }

}
