using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Revitalizer : MonoBehaviour
{
    public static event Action revitalizerAction;
    [SerializeField] GameObject spaceship;
    [SerializeField] float speed = 20;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        revitalizerAction += effect;
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed,speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            revitalizerAction();
            Destroy(gameObject);
        }
    }
    public void effect()
    {
        spaceship.transform.localScale = spaceship.transform.localScale * 0.5f;
    }
    private void OnDisable()
    {
        revitalizerAction -= effect;
    }
}
