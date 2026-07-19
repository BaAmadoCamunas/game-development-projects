using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urlManager : MonoBehaviour
{
    // Code for opening an url in the game (used in credits)
    public void openUrl(string url)
    {
        Application.OpenURL(url);
    }
}
