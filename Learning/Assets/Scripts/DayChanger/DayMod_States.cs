using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayMod_States : MonoBehaviour
{
    public enum GameState
    {
        Day1,
        Day2,
        Day3,
        Day4,
    }

    public   GameState currentGameState;

    void Start()
    {
        currentGameState = GameState.Day1; 
        StartDay(); 
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeDay();
        }
    }

    void ChangeDay()
    {
        switch (currentGameState)
        {
            case GameState.Day1:
                currentGameState = GameState.Day2;
                break;
            case GameState.Day2:
                currentGameState = GameState.Day3;
                break;
            case GameState.Day3:  
                currentGameState= GameState.Day4;
                break;
        }

        StartDay(); 
    }

    void StartDay()
    {
       
        switch (currentGameState)
        {
            case GameState.Day1:
                Debug.Log("Burdell");
              
                break;
            case GameState.Day2:
                Debug.Log("Porcodio");
               
                break;
            case GameState.Day3:
                Debug.Log("Modonnaputtana");
                break;

             case GameState.Day4:
                Debug.Log("Rovaretti Gay");
                break;
        }
    }
}
