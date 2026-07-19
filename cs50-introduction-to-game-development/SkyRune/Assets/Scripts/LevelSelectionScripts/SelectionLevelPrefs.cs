using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionLevelPrefs : MonoBehaviour
{
    #region Variables
    private int PointsLevel1;
    private int PointsLevel2;
    private int PointsLevel3;
    private int PointsLevel4;

    private string Level1_State;
    private string Level2_State;
    private string Level3_State;
    private string Level4_State;



    #endregion


    // Method to delete all the saved scores
    public void Delete()
    {
        PlayerPrefs.SetInt("maxPuntuationLevel1", PointsLevel1);
        PlayerPrefs.SetInt("maxPuntuationLevel2", PointsLevel2);
        PlayerPrefs.SetInt("maxPuntuationLevel3", PointsLevel3);
        PlayerPrefs.SetInt("maxPuntuationLevel4", PointsLevel4);

        PlayerPrefs.SetString("State_Level1", Level1_State);
        PlayerPrefs.SetString("State_Level2", Level2_State);
        PlayerPrefs.SetString("State_Level3", Level3_State);
        PlayerPrefs.SetString("State_Level4", Level4_State);
        
    }

}
