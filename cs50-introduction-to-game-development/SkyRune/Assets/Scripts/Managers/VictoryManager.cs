using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryManager : MonoBehaviour
{
    #region Variables

    [Header("Victory Variables")]
    [SerializeField] private GameObject victoryPanel;

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

    // If the current game state is Victory state, activate victory panel
    private void GameManager_OnGameStateChanged(GameState state)
    {
        if (state == GameState.Victory)
        {
            victoryPanel.SetActive(true);
        }
    }
}
