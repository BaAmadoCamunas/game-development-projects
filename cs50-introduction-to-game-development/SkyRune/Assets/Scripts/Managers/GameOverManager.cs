using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    #region Variables

    [Header("Game Over Variables")]
    [SerializeField] private GameObject gameOverPanel;

    #endregion

    // Methods to manage the state's stack
    void Awake()
    {
        GameManager.OnGameStateChanged += GameManager_OnGameStateChanged;
    }


    void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManager_OnGameStateChanged;
    }

    // If the current game state is GameOver state, activate game over panel
    private void GameManager_OnGameStateChanged(GameState state)
    {

        if (state == GameState.GameOver)
        {
            gameOverPanel.SetActive(true);
        }
    }

}
