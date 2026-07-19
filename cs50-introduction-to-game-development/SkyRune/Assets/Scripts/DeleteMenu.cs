using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMenu : MonoBehaviour
{
    #region Variables

    // Variables for different parts of delete menu

    [Header("Settings")]

    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject DeletePanel;
    [SerializeField] private GameObject Part1;
    [SerializeField] private GameObject Part2;


    #endregion




    private void Awake()
    {
        this.ActivateSettings();
    }


    // Methods for activating different parts of delete menu and settings menu

    public void ActivateSettings()
    {
        SettingsPanel.SetActive(true);
        DeletePanel.SetActive(false);
        Part1.SetActive(false);
        Part2.SetActive(false);
    }

    public void ActivateDeletePanel_Part1()
    {
        SettingsPanel.SetActive(false);
        DeletePanel.SetActive(true);
        Part1.SetActive(true);
        Part2.SetActive(false);
    }

    public void ActivateDeletePanel_Part2()
    {
        SettingsPanel.SetActive(false);
        DeletePanel.SetActive(true);
        Part1.SetActive(false);
        Part2.SetActive(true);
    }
}
