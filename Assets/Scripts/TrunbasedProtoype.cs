using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrunbasedProtoype : MonoBehaviour
{
    public int P1diceRoll;
    public int P2diceRoll;
    private int maxDiceRoll = 10;
    public int firstTurnOrder;
    private int diceRoll;

    public Text diceRollText;

    public string player;

    public List<GameObject> players;
    void Start()
    {
        new List<GameObject>(players);
    }

    void Update()
    {
        //Rull terning for å velge hvem som starter første runde
        //TODO: Rull terning for å bestemme hvor mange tiles spiller beveger seg
        if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                PlayerTurnOrder();
                P1DiceRoller();
            }
        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            P2DiceRoller();
        }
        PlayerTurnOrder();
    }

    public void P1DiceRoller()
    {
        P1diceRoll = Random.Range(1, maxDiceRoll + 1);
        diceRollText.text = P1diceRoll.ToString();
    }

    public void P2DiceRoller()
    {
        P2diceRoll = Random.Range(1, maxDiceRoll + 1);
        diceRollText.text = P2diceRoll.ToString();
    }


    public void PlayerTurnOrder()
    {

        //Velg spiller basert på DiceRoll
        //TODO: modifiser til å bestemme DiceRoll på 2 forskjellige spillere
        if (P1diceRoll > P2diceRoll)
        {
            print("Player 1 Starts");
        }
        else
        {
            print("Player 2 Starts");
        }
    }

    public void TurnSystem()
    {
        //Turn system etter Første spiller har blitt annerkjent/godkjent via DiceRoll
        //    switch (turnOrder)
        //    {
        //        case 1:
        //            PlayerTurnOrder();
        //            break;
        //        case 2:
        //            //ActionTurn
        //            break;
        //        case 3:
        //            //MiniGameTurn
        //            break;
        //        default:
        //            break;
        //    }
    }
}
