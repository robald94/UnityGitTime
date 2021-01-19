using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrunbasedProtoype : MonoBehaviour
{
    public int diceRoll;
    public int maxDiceRoll = 11;
    public int firstTurnOrder;
    public int turnOrder;

    public Text diceRollText;

    public string player;

    public List<GameObject> players;
    void Start()
    {
        new List<GameObject>(players);
        diceRoll = Random.Range(1, maxDiceRoll);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            PlayerTurnOrder();
            DiceRoller();
        }
    }


    public void DiceRoller()
    {
        diceRoll = Random.Range(1, maxDiceRoll);
        diceRollText.text = diceRoll.ToString();
    }

    public void PlayerTurnOrder()
    {
        Debug.Log(diceRoll);

        switch (diceRoll)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                print("PlayerOne");
                break;
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                print("PlayerTwo");
                break;
            default:
                break;
        }
    }

    public void TurnSystem()
    {
        switch (turnOrder)
        {
            case 1:
                PlayerTurnOrder();
                break;
            case 2:
                //ActionTurn
                break;
            case 3:
                //MiniGameTurn
                break;
            default:
                break;
        }
    }
}
