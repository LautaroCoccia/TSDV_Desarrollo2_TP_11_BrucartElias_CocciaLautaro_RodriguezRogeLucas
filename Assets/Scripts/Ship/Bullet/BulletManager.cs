using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shotSpawn;
    private void Start()
    {
        ShipController.instantiateBullet += InstantiateBullet;
        ShipController.instantiateNuke += InstanciateNuke;
    }

    void InstantiateBullet()
    {
        GameObject obj = Instantiate(bulletPrefab, shotSpawn.position, Quaternion.identity);
        obj.SetActive(true);
    }
    void InstanciateNuke()
    {
        GameObject obj = Instantiate(bulletPrefab, shotSpawn.position, Quaternion.identity);
        obj.transform.localScale = new Vector3(obj.transform.localScale.x + 50.0f, obj.transform.localScale.y + 50.0f, obj.transform.localScale.z);
        obj.SetActive(true);
    }
    private void OnDisable()
    {
        ShipController.instantiateBullet -= InstantiateBullet;
        ShipController.instantiateNuke -= InstanciateNuke;
    }

}
