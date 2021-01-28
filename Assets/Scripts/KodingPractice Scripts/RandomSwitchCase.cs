using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSwitchCase : MonoBehaviour
{
    private int rand;
    private int state;

    private void Start()
    {

        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Pressed the button");
            rand = Random.Range(0, 3);
            state = rand;
        }
        switch (rand)
        {
            case 0:
                print($"State is = {state}");
                break;
            case 1:
                print($"State is = {state}");
                break;
            case 2:
                print($"State is = {state}");
                break;
            default:
                print("nope");
                break;
        }
    }
}
