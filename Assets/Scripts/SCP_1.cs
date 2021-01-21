using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCP_1 : MonoBehaviour
{
    public GameObject entityToSpawn;

    public ScriptablePrototype spawnManagerValues;

    public List<GameObject> playersInGame;

    int instanceNumber;
    void Start()
    {

        SpawnEntities();

    }

    void SpawnEntities()
    {
        int currentSpawnPointIndex = 0;

        for (int i = 0; i < spawnManagerValues.numberOfPrefabsToSpawn; i++)
        {
            GameObject currentEntity = Instantiate(entityToSpawn, spawnManagerValues.spawnPoints[currentSpawnPointIndex], Quaternion.identity);

            currentEntity.name = spawnManagerValues.prefabName + instanceNumber;

            currentSpawnPointIndex = (currentSpawnPointIndex + 1) % spawnManagerValues.spawnPoints.Length;

            spawnManagerValues.farge = Random.ColorHSV();
            
            instanceNumber++;

            currentEntity.GetComponent<Renderer>().material.color = spawnManagerValues.farge;
        }
    }

    void Update()
    {
        
    }

}
