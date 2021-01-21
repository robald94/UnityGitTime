using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Menu", menuName = "ScriptablePrototype", order = 1)]
public class ScriptablePrototype : ScriptableObject
{
    public string prefabName;

    public int numberOfPrefabsToSpawn;
    public Vector3[] spawnPoints;
    public Vector2[] turnOrderPoints;

    public Color farge;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
