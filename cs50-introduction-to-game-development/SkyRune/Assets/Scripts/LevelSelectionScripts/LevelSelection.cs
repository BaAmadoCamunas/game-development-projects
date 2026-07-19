using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    #region Variables

    [Header("Level1_Info")]
    [SerializeField] private GameObject Level1_Panel;

    [Header("Level2_Info")]
    [SerializeField] private GameObject Level2_Panel;

    [Header("Level3_Info")]
    [SerializeField] private GameObject Level3_Panel;

    [Header("Level4_Info")]
    [SerializeField] private GameObject Level4_Panel;

    [Header("LevelSelection_Elements")]

    [SerializeField] private GameObject Background;
    [SerializeField] private GameObject Lines;
    [SerializeField] private GameObject Level1;
    [SerializeField] private GameObject Level2;
    [SerializeField] private GameObject Level3;
    [SerializeField] private GameObject Level4;
    [SerializeField] private GameObject BackButton;


    #endregion

    #region Levels display

    // Methods for activating different panels in the Level Selection scene
    public void ActivatePanel_Level1()
    {
        Level1_Panel.SetActive(true);
        Level2_Panel.SetActive(false);
        Level3_Panel.SetActive(false);
        Level4_Panel.SetActive(false);
    }

    public void ActivatePanel_Level2()
    {
        Level1_Panel.SetActive(false);
        Level2_Panel.SetActive(true);
        Level3_Panel.SetActive(false);
        Level4_Panel.SetActive(false);
    }

    public void ActivatePanel_Level3()
    {
        Level1_Panel.SetActive(false);
        Level2_Panel.SetActive(false);
        Level3_Panel.SetActive(true);
        Level4_Panel.SetActive(false);
    }

    public void ActivatePanel_Level4()
    {
        Level1_Panel.SetActive(false);
        Level2_Panel.SetActive(false);
        Level3_Panel.SetActive(false);
        Level4_Panel.SetActive(true);
    }

    public void DeactivatePanel_Level1()
    {
        Level1_Panel.SetActive(false);
        Level2_Panel.SetActive(false);
        Level3_Panel.SetActive(false);
        Level4_Panel.SetActive(false);
    }

    public void DeactivatePanel_Level2()
    {
        Level1_Panel.SetActive(false);
        Level2_Panel.SetActive(false);
        Level3_Panel.SetActive(false);
        Level4_Panel.SetActive(false);
    }

    public void DeactivatePanel_Level3()
    {
        Level1_Panel.SetActive(false);
        Level2_Panel.SetActive(false);
        Level3_Panel.SetActive(false);
        Level4_Panel.SetActive(false);
    }

    public void DeactivatePanel_Level4()
    {
        Level1_Panel.SetActive(false);
        Level2_Panel.SetActive(false);
        Level3_Panel.SetActive(false);
        Level4_Panel.SetActive(false);
    }

    public void Deactivate_Background()
    {
        Background.SetActive(false);
        Lines.SetActive(false);
        Level1.SetActive(false);
        Level2.SetActive(false);
        Level3.SetActive(false);
        Level4.SetActive(false);
        BackButton.SetActive(false);
    }

    public void Activate_Background()
    {
        Background.SetActive(true);
        Lines.SetActive(true);
        Level1.SetActive(true);
        Level2.SetActive(true);
        Level3.SetActive(true);
        Level4.SetActive(true);
        BackButton.SetActive(true);
    }
    #endregion
}
