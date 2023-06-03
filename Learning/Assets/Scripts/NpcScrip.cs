using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NPCMaterialChanger : MonoBehaviour
{
    public DayMod_States gameManager;

    void Update()
    {
        if (gameManager != null)
        {
            DayMod_States.GameState currentState = gameManager.currentGameState;

           
            switch (currentState)
            {
                case DayMod_States.GameState.Day1:
                    Debug.Log("suca1");
                    break;
                case DayMod_States.GameState.Day2:
                    Debug.Log("suca2");
                    break;
                case DayMod_States.GameState.Day3:
                    Debug.Log("suca3");
                    break;
                   
            }
        }
    }
}

