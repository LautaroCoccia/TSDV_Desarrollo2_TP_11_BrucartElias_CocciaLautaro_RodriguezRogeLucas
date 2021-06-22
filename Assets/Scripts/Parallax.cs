using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    private Camera cam;
    public float parallaxeffect;
    void Start()
    {
        cam = Camera.main;
        startpos = transform.position.x;
        length = GetComponentInChildren<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float temp = (cam.transform.position.x * (1-parallaxeffect));
        float dist = (cam.transform.position.x * parallaxeffect);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (temp > startpos + length)
            startpos += length;
        else if (temp < startpos - length)
            startpos -= length;
    }
}
