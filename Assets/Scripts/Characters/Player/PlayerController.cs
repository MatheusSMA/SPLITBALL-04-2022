using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //* references
    private Rigidbody _rb;
    //*

    [Header("Speed variables")]
    [SerializeField] private float _speed;
    private float _movX;


    private void Awake()
    {
        GetReferences();
    }
    void Update()
    {
        InputControls();
    }

    private void InputControls()
    {
        _movX = Input.GetAxis("Horizontal") * _speed;
        _rb.velocity = new Vector3(_movX, 0, 0);
    }

    private void GetReferences()
    {
        _rb = GetComponent<Rigidbody>();
    }
}
