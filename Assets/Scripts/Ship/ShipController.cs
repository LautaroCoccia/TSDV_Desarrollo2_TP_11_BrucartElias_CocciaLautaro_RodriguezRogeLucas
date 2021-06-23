using System;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] private float health = 100;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float shootSpeed;
    [SerializeField] private Transform shotSpawn;
    [SerializeField] private float fireRate;
    private float nextFire;

    static public event Action instantiateBullet;
    static public event Action instantiateNuke;
    static public event Action shake;
    float timeToNuke = 0;
    [SerializeField] float maxTimeNuke = 10;
    void Update()
    {
        Shoot();
        timeToNuke += Time.deltaTime;
    }

    void Shoot()
    {
        if (Input.GetKey(KeyCode.E) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            instantiateBullet?.Invoke();
        }
        if(Input.GetKey(KeyCode.Space) && timeToNuke  > maxTimeNuke)
        {
            timeToNuke = 0;
            instantiateNuke?.Invoke();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            shake?.Invoke();
            Destroy(collision.gameObject);
            health -= 10;
        }
    }
}
