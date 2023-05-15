using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPos = GenerateSpawnPos();
        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
    }

    Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-9, 9);
        float spawnPosZ = Random.Range(-9, 9);
        return new Vector3(spawnPosX, 0, spawnPosZ);
    }
}
