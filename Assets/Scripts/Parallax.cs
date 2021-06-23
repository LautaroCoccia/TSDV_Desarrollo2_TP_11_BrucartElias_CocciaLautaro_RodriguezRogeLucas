using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    public float parallaxeffect;
    float relativeTime = 0;
    void Start()
    {
        startpos = transform.position.y;
        length = GetComponentInChildren<SpriteRenderer>().bounds.size.y;
    }
    
    private void Update()
    {
        relativeTime += Time.deltaTime;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        float temp = (relativeTime * (1-parallaxeffect));
        float dist = (relativeTime * parallaxeffect);

        transform.position = new Vector3(transform.position.x, startpos - dist, transform.position.z);

        if (relativeTime > length/2)
        {
            startpos = 0;
            relativeTime = 0;
        }
        else if (temp < startpos - length)
            startpos -= length;
    }
}
