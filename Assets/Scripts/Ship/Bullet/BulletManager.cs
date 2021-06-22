using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shotSpawn;
    private void Start()
    {
        ShipController.instantiateBullet += InstantiateBullet;
    }

    void InstantiateBullet()
    {
        Instantiate(bulletPrefab, shotSpawn.position, Quaternion.identity);
    }

    private void OnDisable()
    {
        ShipController.instantiateBullet -= InstantiateBullet;
    }

}
