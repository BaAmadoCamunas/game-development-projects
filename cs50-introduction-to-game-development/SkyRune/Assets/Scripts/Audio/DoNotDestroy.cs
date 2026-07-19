using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDestroy : MonoBehaviour
{
    private void Awake()
    {
        // Put in a list all the objects in scene that have the tag "MenuMusic"
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("MenuMusic");

        // If there are more than one menu music in scene, destroy it
        if (tag == "MenuMusic" && musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        // If the current scene is one of the levels, destroy the game object
        if (tag == "MenuMusic" && (SceneManager.GetActiveScene().name == "Level1" || SceneManager.GetActiveScene().name == "Level2" || SceneManager.GetActiveScene().name == "Level3" || SceneManager.GetActiveScene().name == "Level4"))
        {
            Destroy(this.gameObject);
        }
    }
}
