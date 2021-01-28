using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public GameObject movable;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnMove();
        }
    }

    void OnMove()
    {
        movable.transform.position += new Vector3(1, 0, 0);
    }
}
