using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEffect : MonoBehaviour
{

    
    private void Awake()
    {
        // Put in a list all the objects in scene that have the tag "ButtonSound"
        GameObject[] buttonObj = GameObject.FindGameObjectsWithTag("ButtonSound");

        // If there are more than one button sound in scene, destroy it
        if (tag == "ButtonSound" && buttonObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        // If there is one button sound in scene, dont destroy if the scene has changed
        else if (tag == "ButtonSound" && buttonObj.Length <= 1)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }
    private void Update()
    {
        // If the current scene is different from one of the levels or level selection, destroy the sound
        if (tag == "ButtonSound" && (SceneManager.GetActiveScene().name != "Level1" && SceneManager.GetActiveScene().name != "LevelSelection"))
        {
            Destroy(this.gameObject);
            
        }
    }
}
