using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsInfo : MonoBehaviour
{
    #region Variables

    // Variables for different parts of credits
    [Header("CreditsPanels")]

    [SerializeField] private GameObject CreditsPanel_1;
    [SerializeField] private GameObject CreditsPanel_2;
    [SerializeField] private GameObject CreditsPanel_3;
    [SerializeField] private GameObject CreditsPanel_4;
    [SerializeField] private GameObject CreditsPanel_5;

    #endregion


    private void Awake()
    {
       
        ActivateCreditsPanel_1();
    }

    // Methods for activating different parts of credits information

    public void ActivateCreditsPanel_1()
    {
        CreditsPanel_1.SetActive(true);
        CreditsPanel_2.SetActive(false);
        CreditsPanel_3.SetActive(false);
        CreditsPanel_4.SetActive(false);
        CreditsPanel_5.SetActive(false);
    }

    public void ActivateCreditsPanel_2()
    {
        CreditsPanel_1.SetActive(false);
        CreditsPanel_2.SetActive(true);
        CreditsPanel_3.SetActive(false);
        CreditsPanel_4.SetActive(false);
        CreditsPanel_5.SetActive(false);
    }

    public void ActivateCreditsPanel_3()
    {
        CreditsPanel_1.SetActive(false);
        CreditsPanel_2.SetActive(false);
        CreditsPanel_3.SetActive(true);
        CreditsPanel_4.SetActive(false);
        CreditsPanel_5.SetActive(false);
    }

    public void ActivateCreditsPanel_4()
    {
        CreditsPanel_1.SetActive(false);
        CreditsPanel_2.SetActive(false);
        CreditsPanel_3.SetActive(false);
        CreditsPanel_4.SetActive(true);
        CreditsPanel_5.SetActive(false);
    }

    public void ActivateCreditsPanel_5()
    {
        CreditsPanel_1.SetActive(false);
        CreditsPanel_2.SetActive(false);
        CreditsPanel_3.SetActive(false);
        CreditsPanel_4.SetActive(false);
        CreditsPanel_5.SetActive(true);
    }
}
