using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //* references
    private Rigidbody rb;
    //*

    [Header("Speed variables")]
    [SerializeField] private float speed;
    private float movX;


    private void Awake()
    {
        GetReferences();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InputControls();
    }

    private void InputControls()
    {
        movX = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector3(movX, 0, 0);
    }

    private void GetReferences()
    {
        rb = GetComponent<Rigidbody>();
    }
}
