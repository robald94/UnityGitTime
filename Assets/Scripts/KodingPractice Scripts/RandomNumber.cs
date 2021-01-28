using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    private int rand;

    private void Start()
    {
        rand = Random.Range(0, 101);

        if (rand <= 20)
        {
            print("Low");
        }
        else if (rand <= 80)
        {
            print("good");
        }
        else
        {
            print("high");
        }
        print(rand);

    }
}
