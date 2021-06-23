using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int lives;
    [SerializeField] private float speed;

    private void Update()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bulletLimit")
            Destroy(gameObject);

        if(collision.gameObject.layer == 10)
        {
            ItemSpawner.spawnItem?.Invoke();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
