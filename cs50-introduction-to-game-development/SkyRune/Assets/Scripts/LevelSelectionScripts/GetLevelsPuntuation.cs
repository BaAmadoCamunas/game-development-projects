using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetLevelsPuntuation : MonoBehaviour
{
    #region Variables
    [Header("Level_1")]
    [SerializeField] private GameObject Level1_Unlocked;
    [SerializeField] private GameObject Level1_Completed;
    [SerializeField] private GameObject Level1_ZeroStars;
    [SerializeField] private GameObject Level1_OneStars;
    [SerializeField] private GameObject Level1_TwoStars;
    [SerializeField] private GameObject Level1_ThreeStars;
    [SerializeField] private TMP_Text Level1_Puntuation;

    [Header("Level_2")]
    [SerializeField] private GameObject Level2_Locked;
    [SerializeField] private GameObject Level2_Unlocked;
    [SerializeField] private GameObject Level2_Completed;
    [SerializeField] private GameObject Level2_ZeroStars;
    [SerializeField] private GameObject Level2_OneStars;
    [SerializeField] private GameObject Level2_TwoStars;
    [SerializeField] private GameObject Level2_ThreeStars;
    [SerializeField] private TMP_Text Level2_Puntuation;

    [Header("Level_3")]
    [SerializeField] private GameObject Level3_Locked;
    [SerializeField] private GameObject Level3_Unlocked;
    [SerializeField] private GameObject Level3_Completed;
    [SerializeField] private GameObject Level3_ZeroStars;
    [SerializeField] private GameObject Level3_OneStars;
    [SerializeField] private GameObject Level3_TwoStars;
    [SerializeField] private GameObject Level3_ThreeStars;
    [SerializeField] private TMP_Text Level3_Puntuation;

    [Header("Level_4")]
    [SerializeField] private GameObject Level4_Locked;
    [SerializeField] private GameObject Level4_Unlocked;
    [SerializeField] private GameObject Level4_Completed;
    [SerializeField] private GameObject Level4_ZeroStars;
    [SerializeField] private GameObject Level4_OneStars;
    [SerializeField] private GameObject Level4_TwoStars;
    [SerializeField] private GameObject Level4_ThreeStars;
    [SerializeField] private TMP_Text Level4_Puntuation;

    [Header("Lines")]
    [SerializeField] private GameObject Line1_Locked;
    [SerializeField] private GameObject Line1_Unlocked;
    [SerializeField] private GameObject Line2_Locked;
    [SerializeField] private GameObject Line2_Unlocked;
    [SerializeField] private GameObject Line3_Locked;
    [SerializeField] private GameObject Line3_Unlocked;


    private string Level1State;
    private string Level2State;
    private string Level3State;
    private string Level4State;




    private int Level1Puntuation = 0;
    private int Level2Puntuation = 0;
    private int Level3Puntuation = 0;
    private int Level4Puntuation = 0;

    #endregion

    #region Levels

    void Awake()
    {

        //LEVEL 1

        // Checks if Level 1 is completed and activate the UI
        Level1State = PlayerPrefs.GetString("State_Level1");
        if (Level1State == "Completed")
        {
            Level1_Unlocked.SetActive(false);
            Level1_Completed.SetActive(true);

            Line1_Locked.SetActive(false);
            Line1_Unlocked.SetActive(true);
            Line2_Locked.SetActive(true);
            Line2_Unlocked.SetActive(false);
            Line3_Locked.SetActive(true);
            Line3_Unlocked.SetActive(false);

            this.check_Level1();
        }
        else
        {
            Level1_Unlocked.SetActive(true);
            Level1_Completed.SetActive(false);

            Line1_Locked.SetActive(true);
            Line1_Unlocked.SetActive(false);
            Line2_Locked.SetActive(true);
            Line2_Unlocked.SetActive(false);
            Line3_Locked.SetActive(true);
            Line3_Unlocked.SetActive(false);

            this.check_Level1();
        }



        //LEVEL 2

        // Checks if Level2 is locked, unlocked or completed
        Level2State = PlayerPrefs.GetString("State_Level2");
        if (Level2State == "Unlocked")
        {
            Level2_Locked.SetActive(false);
            Level2_Unlocked.SetActive(true);
            Level2_Completed.SetActive(false);

            Line1_Locked.SetActive(false);
            Line1_Unlocked.SetActive(true);
            Line2_Locked.SetActive(true);
            Line2_Unlocked.SetActive(false);
            Line3_Locked.SetActive(true);
            Line3_Unlocked.SetActive(false);

            this.check_Level2();
        }
        else if (Level2State == "Completed")
        {
            Level2_Locked.SetActive(false);
            Level2_Unlocked.SetActive(false);
            Level2_Completed.SetActive(true);

            Line1_Locked.SetActive(false);
            Line1_Unlocked.SetActive(true);
            Line2_Locked.SetActive(false);
            Line2_Unlocked.SetActive(true);
            Line3_Locked.SetActive(true);
            Line3_Unlocked.SetActive(false);

            this.check_Level2();
        }
        else
        {
            Level2_Locked.SetActive(true);
            Level2_Unlocked.SetActive(false);
            Level2_Completed.SetActive(false);
        }



        //LEVEL 3

        // Checks if Level3 is locked, unlocked or completed
        Level3State = PlayerPrefs.GetString("State_Level3");
        if (Level3State == "Unlocked")
        {
            Level3_Locked.SetActive(false);
            Level3_Unlocked.SetActive(true);
            Level3_Completed.SetActive(false);

            Line1_Locked.SetActive(false);
            Line1_Unlocked.SetActive(true);
            Line2_Locked.SetActive(false);
            Line2_Unlocked.SetActive(true);
            Line3_Locked.SetActive(true);
            Line3_Unlocked.SetActive(false);

            this.check_Level3();
        }
        else if (Level3State == "Completed")
        {
            Level3_Locked.SetActive(false);
            Level3_Unlocked.SetActive(false);
            Level3_Completed.SetActive(true);

            Line1_Locked.SetActive(false);
            Line1_Unlocked.SetActive(true);
            Line2_Locked.SetActive(false);
            Line2_Unlocked.SetActive(true);
            Line3_Locked.SetActive(false);
            Line3_Unlocked.SetActive(true);

            this.check_Level3();
        }
        else
        {
            Level3_Locked.SetActive(true);
            Level3_Unlocked.SetActive(false);
            Level3_Completed.SetActive(false);
        }




        //LEVEL 4

        // Checks if Level4 is locked, unlocked or completed
        Level4State = PlayerPrefs.GetString("State_Level4");
        if (Level4State == "Unlocked")
        {
            Level4_Locked.SetActive(false);
            Level4_Unlocked.SetActive(true);
            Level4_Completed.SetActive(false);

            Line1_Locked.SetActive(false);
            Line1_Unlocked.SetActive(true);
            Line2_Locked.SetActive(false);
            Line2_Unlocked.SetActive(true);
            Line3_Locked.SetActive(false);
            Line3_Unlocked.SetActive(true);

            this.check_Level4();
        }
        else if (Level4State == "Completed")
        {
            Level4_Locked.SetActive(false);
            Level4_Unlocked.SetActive(false);
            Level4_Completed.SetActive(true);

            Line1_Locked.SetActive(false);
            Line1_Unlocked.SetActive(true);
            Line2_Locked.SetActive(false);
            Line2_Unlocked.SetActive(true);
            Line3_Locked.SetActive(false);
            Line3_Unlocked.SetActive(true);

            this.check_Level4();
        }
        else
        {
            Level4_Locked.SetActive(true);
            Level4_Unlocked.SetActive(false);
            Level4_Completed.SetActive(false);
        }
    }



    private void check_Level1()
    {
        // GetInt of playerprefs of the level's 1 score
        Level1Puntuation = PlayerPrefs.GetInt("maxPuntuationLevel1");
        // The stars are activate depending on the score and the score is displayed on the screen
        if(Level1Puntuation <= 0)
        {
            PlayerPrefs.SetString("State_Level1", "Unlocked");
        }
        else if (Level1Puntuation < 75)
        {
            Level1_ZeroStars.SetActive(true);
            Level1_OneStars.SetActive(false);
            Level1_TwoStars.SetActive(false);
            Level1_ThreeStars.SetActive(false);
            Level1_Puntuation.text = Level1Puntuation.ToString();
        }
        else if (Level1Puntuation >= 75 && Level1Puntuation < 175)
        {
            Level1_ZeroStars.SetActive(false);
            Level1_OneStars.SetActive(true);
            Level1_TwoStars.SetActive(false);
            Level1_ThreeStars.SetActive(false);
            Level1_Puntuation.text = Level1Puntuation.ToString();
        }
        else if (Level1Puntuation >= 175 && Level1Puntuation < 275)
        {
            Level1_ZeroStars.SetActive(false);
            Level1_OneStars.SetActive(false);
            Level1_TwoStars.SetActive(true);
            Level1_ThreeStars.SetActive(false);
            Level1_Puntuation.text = Level1Puntuation.ToString();
        }
        else if (Level1Puntuation >= 275)
        {
            Level1_ZeroStars.SetActive(false);
            Level1_OneStars.SetActive(false);
            Level1_TwoStars.SetActive(false);
            Level1_ThreeStars.SetActive(true);
            Level1_Puntuation.text = Level1Puntuation.ToString();
        }
    }

    private void check_Level2()
    {
        // GetInt of playerprefs of the level's 2 score
        Level2Puntuation = PlayerPrefs.GetInt("maxPuntuationLevel2");
        // The stars are activate depending on the score and the score is displayed on the screen
        if (Level2Puntuation < 129)
        {
            Level2_ZeroStars.SetActive(true);
            Level2_OneStars.SetActive(false);
            Level2_TwoStars.SetActive(false);
            Level2_ThreeStars.SetActive(false);
            Level2_Puntuation.text = Level2Puntuation.ToString();
        }
        else if (Level2Puntuation >= 129 && Level2Puntuation < 229)
        {
            Level2_ZeroStars.SetActive(false);
            Level2_OneStars.SetActive(true);
            Level2_TwoStars.SetActive(false);
            Level2_ThreeStars.SetActive(false);
            Level2_Puntuation.text = Level2Puntuation.ToString();
        }
        else if (Level2Puntuation >= 229 && Level2Puntuation < 329)
        {
            Level2_ZeroStars.SetActive(false);
            Level2_OneStars.SetActive(false);
            Level2_TwoStars.SetActive(true);
            Level2_ThreeStars.SetActive(false);
            Level2_Puntuation.text = Level2Puntuation.ToString();
        }
        else if (Level2Puntuation >= 329)
        {
            Level2_ZeroStars.SetActive(false);
            Level2_OneStars.SetActive(false);
            Level2_TwoStars.SetActive(false);
            Level2_ThreeStars.SetActive(true);
            Level2_Puntuation.text = Level2Puntuation.ToString();
        }
    }

    private void check_Level3()
    {
        // GetInt of playerprefs of the level's 3 score
        Level3Puntuation = PlayerPrefs.GetInt("maxPuntuationLevel3");
        // The stars are activate depending on the score and the score is displayed on the screen
        if (Level3Puntuation < 150)
        {
            Level3_ZeroStars.SetActive(true);
            Level3_OneStars.SetActive(false);
            Level3_TwoStars.SetActive(false);
            Level3_ThreeStars.SetActive(false);
            Level3_Puntuation.text = Level3Puntuation.ToString();
        }
        else if (Level3Puntuation >= 150 && Level3Puntuation < 300)
        {
            Level3_ZeroStars.SetActive(false);
            Level3_OneStars.SetActive(true);
            Level3_TwoStars.SetActive(false);
            Level3_ThreeStars.SetActive(false);
            Level3_Puntuation.text = Level3Puntuation.ToString();
        }
        else if (Level3Puntuation >= 300 && Level3Puntuation < 452)
        {
            Level3_ZeroStars.SetActive(false);
            Level3_OneStars.SetActive(false);
            Level3_TwoStars.SetActive(true);
            Level3_ThreeStars.SetActive(false);
            Level3_Puntuation.text = Level3Puntuation.ToString();
        }
        else if (Level3Puntuation >= 452)
        {
            Level3_ZeroStars.SetActive(false);
            Level3_OneStars.SetActive(false);
            Level3_TwoStars.SetActive(false);
            Level3_ThreeStars.SetActive(true);
            Level3_Puntuation.text = Level3Puntuation.ToString();
        }
    }


    private void check_Level4()
    {
        // GetInt of playerprefs of the level's 4 score
        Level4Puntuation = PlayerPrefs.GetInt("maxPuntuationLevel4");
        // The stars are activate depending on the score and the score is displayed on the screen
        if (Level4Puntuation < 300)
        {
            Level4_ZeroStars.SetActive(true);
            Level4_OneStars.SetActive(false);
            Level4_TwoStars.SetActive(false);
            Level4_ThreeStars.SetActive(false);
            Level4_Puntuation.text = Level4Puntuation.ToString();
        }
        else if (Level4Puntuation >= 300 && Level4Puntuation < 600)
        {
            Level4_ZeroStars.SetActive(false);
            Level4_OneStars.SetActive(true);
            Level4_TwoStars.SetActive(false);
            Level4_ThreeStars.SetActive(false);
            Level4_Puntuation.text = Level4Puntuation.ToString();
        }
        else if (Level4Puntuation >= 600 && Level4Puntuation < 900)
        {
            Level4_ZeroStars.SetActive(false);
            Level4_OneStars.SetActive(false);
            Level4_TwoStars.SetActive(true);
            Level4_ThreeStars.SetActive(false);
            Level4_Puntuation.text = Level4Puntuation.ToString();
        }
        else if (Level4Puntuation >= 900)
        {
            Level4_ZeroStars.SetActive(false);
            Level4_OneStars.SetActive(false);
            Level4_TwoStars.SetActive(false);
            Level4_ThreeStars.SetActive(true);
            Level4_Puntuation.text = Level4Puntuation.ToString();
        }
    }

    #endregion
}
