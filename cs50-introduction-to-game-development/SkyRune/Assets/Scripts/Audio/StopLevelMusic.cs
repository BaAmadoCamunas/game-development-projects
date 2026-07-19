using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopLevelMusic : MonoBehaviour
{
    private void Awake()
    {
        // Put in a list all the objects in scene that have the tag "LevelMusic"
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("LevelMusic");

        // If there are more than one level music in scene, destroy it
        if (tag == "LevelMusic" && musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        // If the current scene is different of one of the levels, destroy the game object
        if (tag == "LevelMusic" && (SceneManager.GetActiveScene().name != "Level1" && SceneManager.GetActiveScene().name != "Level2" && SceneManager.GetActiveScene().name != "Level3" && SceneManager.GetActiveScene().name != "Level4"))
        {
            Destroy(this.gameObject);
        }
    }
}
