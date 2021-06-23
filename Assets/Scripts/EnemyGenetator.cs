using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenetator : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyList;
    [SerializeField] float actualTime;
    [SerializeField] float timeToSpawn;

    // Update is called once per frame
    void Update()
    {
        if(actualTime<timeToSpawn)
        {
            actualTime += Time.deltaTime / 2;
        }
        else
        {
            actualTime = 0;
            Instantiate(enemyList[ Random.Range(0, enemyList.Count)]);
        }
    }
}
