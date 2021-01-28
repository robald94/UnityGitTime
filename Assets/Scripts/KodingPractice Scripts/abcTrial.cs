using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abcTrial : MonoBehaviour
{
    int a, b, c;


    private void Start()
    {
        a = 7;
        b = a;
        c = b++;
        b = a + b * c;
        c = a >= 100 ? b : c / 10;
        a = (int)Mathf.Sqrt(b * b + c * c);

        string s = "String literal";
        char l = s[s.Length - 1];

        var numbers = new List<int>(new[] { 1, 2, 3 });
        b = numbers.FindLast(n => n > 1);

       
    }

}
