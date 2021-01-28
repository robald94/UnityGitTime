using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsPressed : MonoBehaviour
{
    public void OnPressedPlay()
    {
        Application.LoadLevel(1);
    }
}
