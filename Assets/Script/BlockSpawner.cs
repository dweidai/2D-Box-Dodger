using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject box;
    public float betweenWaves = 1f;
    float timetoSpawn = 2f;
    // Update is called once per frame
    void Update()
    {
        if(Time.time > timetoSpawn)
        {
            SpawnBox();
            timetoSpawn = Time.time + betweenWaves;
        }

    }

    void SpawnBox()
    {
        int index1 = Random.Range(0, spawnPoints.Length);
        int index2 = Random.Range(0, spawnPoints.Length);
        for(int i=0; i<spawnPoints.Length; i++)
        {
            if(index1 != i && index2 != i)
            {
                Instantiate(box, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
