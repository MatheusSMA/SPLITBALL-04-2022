using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject attackPoint;
    [SerializeField] private GameObject hopeBullet;
    [SerializeField] private float shootForce;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(hopeBullet, attackPoint.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.up * shootForce, ForceMode.Impulse);
        }


    }
}
