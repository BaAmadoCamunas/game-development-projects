using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInfo : MonoBehaviour
{
    #region Variables

    // Variables for different parts of tutorial information
    [Header("TutorialPanels")]

    [SerializeField] private GameObject Part_1;
    [SerializeField] private GameObject Part_2;
    [SerializeField] private GameObject Part_3;
    [SerializeField] private GameObject Part_4;
    [SerializeField] private GameObject Part_5;
    [SerializeField] private GameObject Part_6;
    [SerializeField] private GameObject Part_7;
    [SerializeField] private GameObject Part_8;
    [SerializeField] private GameObject Part_9;
    [SerializeField] private GameObject Part_10;
    [SerializeField] private GameObject Part_11;
    [SerializeField] private GameObject Part_12;
    [SerializeField] private GameObject Part_13;

    #endregion


    #region Tutorial

    private void Awake()
    {
        this.ActivateTutorialPart1();
    }


    // Methods for activating different parts of tutorial
    public void ActivateTutorialPart1()
    {
        Part_1.SetActive(true);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart2()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(true);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart3()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(true);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart4()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(true);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart5()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(true);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart6()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(true);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart7()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(true);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart8()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(true);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart9()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(true);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart10()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(true);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart11()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(true);
        Part_12.SetActive(false);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart12()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(true);
        Part_13.SetActive(false);
    }

    public void ActivateTutorialPart13()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
        Part_11.SetActive(false);
        Part_12.SetActive(false);
        Part_13.SetActive(true);
    }

    #endregion
}
