using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ScreenShake : MonoBehaviour
{
    [SerializeField] float time = 0;
    [SerializeField] float actualTime = 0;
    [SerializeField] float shakeAmount = 0.7f;
    [SerializeField] float decreaseFactor = 1;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        ShipController.shake += Shake;
        startPos = gameObject.transform.position;
    }
    void Shake()
    {
        StartCoroutine(Shaker());
    }
    IEnumerator Shaker()
    {
        actualTime = time;
        while(actualTime >0)
        {
            transform.position = UnityEngine.Random.insideUnitSphere * shakeAmount;
            transform.position = new Vector3(transform.position.x, transform.position.y, startPos.z);
            actualTime -= Time.deltaTime * decreaseFactor;
            yield return null;
        }
        actualTime = 0;
        transform.position = startPos;
    }
    private void OnDisable()
    {
        ShipController.shake -= Shake;
    }
}
