using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody rb;
    [Header("Speed")]
    [SerializeField] private float velocityFactor;// only applies to gravity for now
    [Header("Direction")]
    [Range(-1, 1)]
    [SerializeField] private float direction;// direction to move
    [SerializeField] private float velocityDirection;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(direction, -9.8f * velocityFactor, 0);
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
