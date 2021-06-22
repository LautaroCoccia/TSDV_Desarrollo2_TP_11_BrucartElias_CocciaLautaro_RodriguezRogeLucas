using System;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float shootSpeed;
    [SerializeField] private Transform shotSpawn;
    [SerializeField] private float fireRate;
    private float nextFire;

    static public event Action instantiateBullet;

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKey(KeyCode.E) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            instantiateBullet?.Invoke();
        }
    }
}
