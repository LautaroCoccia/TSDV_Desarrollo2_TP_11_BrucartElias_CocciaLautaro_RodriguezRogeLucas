using UnityEngine;
using System;
public class Enemy : MonoBehaviour
{
    public enum EnemyType
    {
        bomber,
        fighter
    }
    private enum EnemyState
    {
        GoingToTarget,
        GoBack
    }
    [SerializeField] private float speed;
    [SerializeField] private EnemyType type;
    [SerializeField] private GameObject ship;
    [SerializeField] private Vector3 firstPoint;
    [SerializeField] private Vector3 secondPoint;
    [SerializeField] private Vector3 offsetWithShip;

    private Rigidbody2D rb;
    private EnemyState state;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        state = EnemyState.GoingToTarget;
    }
    void Update()
    {
        Move();
    }
    void Move()
    {
        float distance;
        Vector3 newPosition;
        switch (state)
        {
            case EnemyState.GoingToTarget:
                newPosition = Vector3.Lerp(transform.position, secondPoint, speed * Time.deltaTime);
                transform.position = newPosition;
                distance = Vector3.Distance(ship.transform.position, transform.position);

                if (distance >= 10.0f)
                    state = EnemyState.GoBack;
                break;
            case EnemyState.GoBack:
                newPosition = Vector3.Lerp(transform.position, firstPoint, speed * Time.deltaTime);
                transform.position = newPosition;
                distance = Vector3.Distance(ship.transform.position, transform.position);
                if (distance >= 10.0f)
                    state = EnemyState.GoingToTarget;
                break;
            default:
                break;
        }
    }
}
