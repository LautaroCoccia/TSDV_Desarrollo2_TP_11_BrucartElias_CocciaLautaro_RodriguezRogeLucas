using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int lives;
    [SerializeField] float speed;

    private void Update()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
