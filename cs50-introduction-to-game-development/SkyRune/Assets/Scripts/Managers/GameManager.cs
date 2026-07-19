using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables

    public static GameManager Instance;

    public GameState State;

    public static event Action<GameState> OnGameStateChanged;

    #endregion


    void Awake()
    {
        Instance = this;

    }

    // Activate the forst state of the game (Mission state) and stop game's time
    void Start()
    {
        UpdateGameState(GameState.Mission);
        Time.timeScale = 0;
    }

    // Method to let the game changes states
    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.Mission:
                break;

            case GameState.Level:
                break;

            case GameState.Victory:
                break;

            case GameState.GameOver:
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChanged?.Invoke(newState);
    }

}

// All the game's states
public enum GameState
{
    Mission,
    Level,
    Victory,
    GameOver
}
