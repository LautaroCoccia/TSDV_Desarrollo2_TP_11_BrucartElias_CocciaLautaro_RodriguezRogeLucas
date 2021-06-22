using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BulletScaler : MonoBehaviour, IItem
{
    public static event Action collisionAction;
    [SerializeField] GameObject spaceship;
    [SerializeField] float speed = 20;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        collisionAction += effect;
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed,speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            collisionAction();
            Destroy(gameObject);
        }
    }
    public void effect()
    {
        spaceship.transform.localScale = spaceship.transform.localScale * 2;
    }
    private void OnDisable()
    {
        collisionAction -= effect;
    }
}
