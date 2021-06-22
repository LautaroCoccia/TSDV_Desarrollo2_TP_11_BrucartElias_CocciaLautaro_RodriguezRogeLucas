using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : MonoBehaviour
{
    [SerializeField] float maxX;
    [SerializeField] float maxY;
    [SerializeField] float speed;
    enum FromDirection
    {
        up,
        down,
        left,
        right
    }
    FromDirection direc;
    // Start is called before the first frame update
    private void Start()
    {
        GetRandomState();
    }
    // Update is called once per frame
    void Update()
    {
        switch(direc)
        {
            case FromDirection.up:
                if (transform.position.y >= -maxY)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
                }
                else
                    GetRandomState();
                break;
            case FromDirection.down:
                if(transform.position.y <= maxY)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);

                }
                else
                    GetRandomState();
                break;
            case FromDirection.left:
                if(transform.position.x <= maxX)
                {
                    transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y , transform.position.z);

                }
                else
                    GetRandomState();
                break;
            case FromDirection.right:
                if (transform.position.x >= -maxX)
                {
                    transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);

                }
                else
                    GetRandomState();
                break;
        }
    }
    void GetRandomState()
    {
        direc = (FromDirection)Random.Range(0, 4);
        if(direc == FromDirection.up)
        {
            SetStartPos(Random.Range(-maxX, maxX), maxY);
        }
        else if(direc == FromDirection.down)
        {
            SetStartPos(Random.Range(-maxX, maxX), -maxY);
        }
        else if(direc == FromDirection.left)
        {
            SetStartPos(-maxX, Random.Range(-maxY,maxY));
        }
        else if(direc == FromDirection.right)
        {
            SetStartPos(maxX, Random.Range(-maxY, maxY));

        }

    }
    void SetStartPos(float x, float y)
    { 
        transform.position = new Vector3(x, y, 0);
    }
}
