using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadActivated : MonoBehaviour
{
    #region Variables

    public GameObject[] gems;




    #endregion

    private void Awake()
    {
        for (int i = 0; i < gems.Length; i++)
        {
            gems[i].SetActive(false);
        }
    }

    // If the player drop a small box over the pressed pad, activate the invisible gems
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PickableBox")
        {
            for(int i = 0; i < gems.Length; i++)
            {
                gems[i].SetActive(true);
            }
        }
    }
}
