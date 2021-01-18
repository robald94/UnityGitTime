using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrunbasedProtoype : MonoBehaviour
{
    public int diceRoll;
    public int maxDiceRoll = 10;
    public int turnorder;

    public Text diceRollText;

    public List<GameObject> players;
    void Start()
    {
        new List<GameObject>(players);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            DiceRoller();
        }
    }


    public void DiceRoller()
    {
        diceRoll = Random.Range(1, maxDiceRoll);
        diceRollText.text = diceRoll.ToString();
        Debug.Log(diceRoll);
        PlayerTurnOrder();
    }

    public void PlayerTurnOrder()
    {
        switch (turnorder)
        {
            case 1:
                if(diceRoll == Random.Range(1, 5))
                {
                    print("Playerone starts");
                }
                break;
            case 2:
                if (diceRoll == Random.Range(6, 10))
                {
                    print("Playertwo starts");
                }
                break;
            default:
                print("Playerone Starts");
                break;
        }
    }
}
