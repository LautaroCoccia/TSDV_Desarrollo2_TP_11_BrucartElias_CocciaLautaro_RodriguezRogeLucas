using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float shootSpeed;
    [SerializeField] private Transform shotSpawn;
    [SerializeField] private float fireRate;
    private float nextFire;
    void Start()
    {
        
    }

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKey(KeyCode.E) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, shotSpawn.position, Quaternion.identity);
        }
    }
}
