using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region Variables

    [Header("Level Variables")]
    [SerializeField] private GameObject missionPanel;
    [SerializeField] private GameObject LevelUI;

    public static LevelManager Instance_level;

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


    // If the current game state is Level state, activate level UI and recover game time
    private void GameManager_OnGameStateChanged(GameState state)
    {
        missionPanel.SetActive(state == GameState.Mission);
        LevelUI.SetActive(state == GameState.Level);
        Time.timeScale = 1;
    }


}
