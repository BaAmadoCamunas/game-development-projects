using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishLevel : MonoBehaviour
{
    #region Variables

    [Header("Finish Level Variables")]
    private bool finish = false;

    private int currentPuntuation = 0;
    private int Level1Score = 0;
    private int Level2Score = 0;
    private int Level3Score = 0;
    private int Level4Score = 0;

    [SerializeField] private TMP_Text Level_Puntuation;

    public AudioSource victory;

    #endregion

    private void Update()
    {
        // If level has finished, stop game time
        if(finish == true) 
        {
            Time.timeScale = 0;
        }

        

    }

    // Method for detect if character collides with finish level object
    private void OnTriggerEnter(Collider other)
    {
        // If finish level object has the tag "FinishLevel1" and the player has the gem required for passed Level 1
        if(other.tag =="FinishLevel_1" && this.GetComponent<PlayerInventory>().BlueKey == true)
        {
            // Destroy Level music and play victory sound
            GameObject musicObj = GameObject.FindGameObjectWithTag("LevelMusic");
            Destroy(musicObj);
            victory.Play();
            StartCoroutine(VictoryWait(0.3f));
            finish = true;

            // Change the game state to Victory
            GameManager.Instance.UpdateGameState(GameState.Victory);

            // Save the puntuation if it's greater than the one obtained before in this level 
            SavePuntuationLevel1();

        }
        // If finish level object has the tag "FinishLevel2" and the player has the gem required for passed Level 2
        else if (other.tag == "FinishLevel_2" && this.GetComponent<PlayerInventory>().PurpleKey == true)
        {
            // Destroy Level music and play victory sound
            GameObject musicObj = GameObject.FindGameObjectWithTag("LevelMusic");
            Destroy(musicObj);
            victory.Play();
            StartCoroutine(VictoryWait(0.3f));
            finish = true;

            // Change the game state to Victory
            GameManager.Instance.UpdateGameState(GameState.Victory);

            // Save the puntuation if it's greater than the one obtained before in this level 
            SavePuntuationLevel2();
        }
        // If finish level object has the tag "FinishLevel3" and the player has the gem required for passed Level 3
        else if (other.tag == "FinishLevel_3" && this.GetComponent<PlayerInventory>().MoonKey == true)
        {
            // Destroy Level music and play victory sound
            GameObject musicObj = GameObject.FindGameObjectWithTag("LevelMusic");
            Destroy(musicObj);
            victory.Play();
            StartCoroutine(VictoryWait(0.3f));
            finish = true;

            // Change the game state to Victory
            GameManager.Instance.UpdateGameState(GameState.Victory);

            // Save the puntuation if it's greater than the one obtained before in this level 
            SavePuntuationLevel3();
        }
        // If finish level object has the tag "FinishLevel4" and the player has the gem required for passed Level 4
        else if (other.tag == "FinishLevel_4" && this.GetComponent<PlayerInventory>().BlueKey == true && this.GetComponent<PlayerInventory>().PurpleKey == true && this.GetComponent<PlayerInventory>().MoonKey == true)
        {
            // Destroy Level music and play victory sound
            GameObject musicObj = GameObject.FindGameObjectWithTag("LevelMusic");
            Destroy(musicObj);
            victory.Play();
            StartCoroutine(VictoryWait(0.3f));
            finish = true;

            // Change the game state to Victory
            GameManager.Instance.UpdateGameState(GameState.Victory);

            // Save the puntuation if it's greater than the one obtained before in this level 
            SavePuntuationLevel4();
        }
    }

    // Corrutine for let victory audio sound before changing game state
    IEnumerator VictoryWait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }


    // Save Level 1 score
    private void SavePuntuationLevel1()
    {
        // Get the current puntuation
        currentPuntuation = this.GetComponent<PlayerInventory>().NumberOfGems;
        Level_Puntuation.text = currentPuntuation.ToString();

        Level1Score = PlayerPrefs.GetInt("maxPuntuationLevel1");

        // If the current puntuation is greater than the one that is save from the level, update it
        if (currentPuntuation > Level1Score)
        {
            PlayerPrefs.SetInt("maxPuntuationLevel1", currentPuntuation);
        }
        else
        {
            //Do nothing
        }

        // Update current level state
        if(currentPuntuation > 0)
        {
            PlayerPrefs.SetString("State_Level1", "Completed");

            if (PlayerPrefs.GetInt("maxPuntuationLevel2") > 0)
            {
                //Do nothing
            }
            else
            {
                PlayerPrefs.SetString("State_Level2", "Unlocked");
            }
        }
        
    }

    // Save Level 2 score
    private void SavePuntuationLevel2()
    {
        // Get the current puntuation
        currentPuntuation = this.GetComponent<PlayerInventory>().NumberOfGems;
        Level_Puntuation.text = currentPuntuation.ToString();

        Level2Score = PlayerPrefs.GetInt("maxPuntuationLevel2");

        // If the current puntuation is greater than the one that is save from the level, update it
        if (currentPuntuation > Level2Score)
        {
            PlayerPrefs.SetInt("maxPuntuationLevel2", currentPuntuation);
        }
        else
        {
            //Do nothing
        }

        // Update current level state
        if (currentPuntuation > 0)
        {
            PlayerPrefs.SetString("State_Level2", "Completed");

            if (PlayerPrefs.GetInt("maxPuntuationLevel3") > 0)
            {
                //Do nothing
            }
            else
            {
                PlayerPrefs.SetString("State_Level3", "Unlocked");
            }
        }
        
    }

    // Save Level 3 score
    private void SavePuntuationLevel3()
    {
        // Get the current puntuation
        currentPuntuation = this.GetComponent<PlayerInventory>().NumberOfGems;
        Level_Puntuation.text = currentPuntuation.ToString();

        Level3Score = PlayerPrefs.GetInt("maxPuntuationLevel3");

        // If the current puntuation is greater than the one that is save from the level, update it
        if (currentPuntuation > Level3Score)
        {
            PlayerPrefs.SetInt("maxPuntuationLevel3", currentPuntuation);
        }
        else
        {
            //Do nothing
        }

        // Update current level state
        if (currentPuntuation > 0)
        {
            PlayerPrefs.SetString("State_Level3", "Completed");

            if (PlayerPrefs.GetInt("maxPuntuationLevel4") > 0)
            {
                //Do nothing
            }
            else
            {
                PlayerPrefs.SetString("State_Level4", "Unlocked");
            }
        }

    }

    // Save Level 4 score
    private void SavePuntuationLevel4()
    {
        // Get the current puntuation
        currentPuntuation = this.GetComponent<PlayerInventory>().NumberOfGems;
        Level_Puntuation.text = currentPuntuation.ToString();

        Level4Score = PlayerPrefs.GetInt("maxPuntuationLevel4");

        // If the current puntuation is greater than the one that is save from the level, update it
        if (currentPuntuation > Level4Score)
        {
            PlayerPrefs.SetInt("maxPuntuationLevel4", currentPuntuation);
        }
        else
        {
            //Do nothing
        }

        // Update current level state
        if (currentPuntuation > 0)
        {
            PlayerPrefs.SetString("State_Level4", "Completed");
        }

        

    }
}
