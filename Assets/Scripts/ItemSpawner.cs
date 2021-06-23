using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ItemSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> itemList;
    public static UnityEvent spawnItem;

    // Start is called before the first frame update
    void Start()
    {
        if (spawnItem == null)
            spawnItem = new UnityEvent();
        spawnItem.AddListener(SpawnItem);
    }

    void SpawnItem()
    {
        if (UnityEngine.Random.Range(0, 3) == 0)
        {
            GameObject obj = Instantiate(itemList[UnityEngine.Random.Range(0, itemList.Count)]);
            obj.SetActive(true);
        }
    }
    private void OnDisable()
    {
        spawnItem.RemoveListener(SpawnItem);
    }
}
