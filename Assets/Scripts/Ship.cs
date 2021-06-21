using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    void Update()
    {
        MoveShip();
    }

    void MoveShip()
    {
        if(transform.position.x >= -8)
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x <= 8)
            if (Input.GetKey(KeyCode.RightArrow))
                transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
