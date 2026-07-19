using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    // Corrutine to let button audio sound before changing scene
    IEnumerator SoundWait(string scene)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(scene);
    }

    // Code for change scene giving it's name
    public void changeScene(string nextScene)
    {
        StartCoroutine(SoundWait(nextScene));
    }

    // Code for return to level selection menu
    public void goToLevelSelection(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
       
    }
}
