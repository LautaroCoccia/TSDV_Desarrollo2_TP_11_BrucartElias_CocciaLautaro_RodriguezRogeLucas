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
        //transform.position += new Vector3(x, y, 0) * speed * Time.deltaTime;
        //if (transform.position.x >= -8 && transform.position.x <= 8 && transform.position.y <= 3.70f && transform.position.y >= -3.70f)
        /*if(transform.position.x <= 8)
            if (Input.GetKey(KeyCode.RightArrow))
                transform.position += Vector3.right * speed * Time.deltaTime;
        if(transform.position.y <= 3.70f)
            if (Input.GetKey(KeyCode.UpArrow))
                transform.position += Vector3.up * speed * Time.deltaTime;
        if(transform.position.y >= -3.70f)
            if (Input.GetKey(KeyCode.DownArrow))
                transform.position += Vector3.down * speed * Time.deltaTime;*/
    }
}
