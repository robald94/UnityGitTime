using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<GameObject> assignedPlayersInGame;

    public int P1rollsallowed =1;
    public int P2rollsallowed =0;

    public bool P1turn = true;
    public bool P2turn = false;

    static GameManager instance;

    public static GameManager Instance 
    {
        get
        {
            return instance;
        }
    }
    void Start()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    void Update()
    {
        
    }

}
