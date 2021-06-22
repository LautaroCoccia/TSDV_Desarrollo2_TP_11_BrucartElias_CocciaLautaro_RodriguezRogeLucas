using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombersMovementAround : MonoBehaviour
{
    Transform parent;
    [SerializeField] private float translationRadius = 50;
    [SerializeField] private float translationSpeed = 1;
    [SerializeField] private float radius;
    Vector3 v3 = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        parent = gameObject.GetComponentInParent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        translationRadius += translationSpeed * Time.deltaTime;

        v3.x = parent.position.x + radius * Mathf.Cos(translationRadius);
        v3.y = parent.position.y + radius * Mathf.Sin(translationRadius);

        transform.position = v3;
    }
    
}
