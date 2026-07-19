using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    #region Variables

    [Header("Mission Variables")]
    [SerializeField] private GameObject missionPanel;
    [SerializeField] private GameObject Part1;
    [SerializeField] private GameObject Part2;
    [SerializeField] private GameObject Part3;
    [SerializeField] private GameObject StartButton;
    [SerializeField] private GameObject LevelUI;

    public static MissionManager Instance_mision;

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


    // If the current game state is Mission state, activate mission panel and deactivate level UI
    private void GameManager_OnGameStateChanged(GameState state)
    {
        if(state == GameState.Mission)
        {
            LevelUI.SetActive(false);
            missionPanel.SetActive(true);
        }
    }


    // Method for changing from Mission State to Level State 
    public void StartMission()
    {
        GameManager.Instance.UpdateGameState(GameState.Level);
    }


    // Methods to activate different parts of mission panel
    public void ActivateMision_Part1()
    {
        Part1.SetActive(true);
        Part2.SetActive(false);
        Part3.SetActive(false);
        StartButton.SetActive(false);
    }

    public void ActivateMision_Part2()
    {
        Part1.SetActive(false);
        Part2.SetActive(true);
        Part3.SetActive(false);
        StartButton.SetActive(false);
    }

    public void ActivateMision_Part3()
    {
        Part1.SetActive(false);
        Part2.SetActive(false);
        Part3.SetActive(true);
        StartButton.SetActive(true);
    }
}
