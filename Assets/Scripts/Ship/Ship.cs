using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        MoveShip();
    }

    void MoveShip()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(x, y) * speed;
    }
}
