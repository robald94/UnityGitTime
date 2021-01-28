using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRange : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        Vector3 position = new Vector3(Random.Range(-10f, 10f), Random.Range(-10, 10), 0f);
        Instantiate(prefab, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
