using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int lives;
    private bool canMove;
    void Start()
    {
        canMove = true;
    }
}
