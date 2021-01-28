using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour
{
    void Start()
    {
        GetComponentInChildren<Text>().color  = Color.black;   
    }

    private void OnMouseOver()
    {
        Debug.Log("not here");
        GetComponentInChildren<Text>().color = Color.red;
    }
    private void OnMouseExit()
    {
        GetComponentInChildren<Text>().color = Color.black;
    }
}
