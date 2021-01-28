using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    public int intelligence;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Greet();
            intelligence++;
        }
    }

    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("Well hello there good sir");
                break;
            case 4:
                print("Hello there");
                break;
            case 3:
                print("hi");
                break;
            case 2:
                print("GDAY");
                break;
            case 1:
                print($"{intelligence} this is innsufficient intelligence");
                break;
            default:
                print("nope");
                break;
        }
    }
}
