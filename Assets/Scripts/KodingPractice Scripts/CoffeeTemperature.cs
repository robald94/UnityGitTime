using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTemperature : MonoBehaviour
{
    public float coffeeTemperature = 90f;
    public float hotLimitTemperature = 80f;
    public float coldLimitTemperature = 60f;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureCheck();

            coffeeTemperature -= 5f;
        }
    }

    public void TemperatureCheck()
    {
        if(coffeeTemperature >= 90)
        {
            print("Coffee too hot");
        }
        else if(coffeeTemperature == coldLimitTemperature)
        {
            print("Coffee is Getting cold");
        }
        else
        {
            print($"coffee is too hot");
        }
    }
}
