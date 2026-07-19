using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{

    #region Variables

    public AudioSource collectAudio;

    #endregion


    private void OnTriggerEnter(Collider other)
    {
        // Check if the gem is colliding with the player and deactivate the gem
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory != null)
        {
            if(this.tag == "GreenGem")
            {
                playerInventory.GreenGemCollected();
                collectAudio.Play();
                gameObject.SetActive(false);
            }

            if (this.tag == "BlueGem")
            {
                playerInventory.BlueGemCollected();
                collectAudio.Play();
                gameObject.SetActive(false);
            }

            if (this.tag == "RedGem")
            {
                playerInventory.RedGemCollected();
                collectAudio.Play();
                gameObject.SetActive(false);
            }

            if(this.tag == "BlueKey")
            {
                playerInventory.BlueKeyCollected();
                collectAudio.Play();
                gameObject.SetActive(false);
            }

            if (this.tag == "PurpleKey")
            {
                playerInventory.PurpleKeyCollected();
                collectAudio.Play();
                gameObject.SetActive(false);
            }

            if (this.tag == "MoonKey")
            {
                playerInventory.MoonKeyCollected();
                collectAudio.Play();
                gameObject.SetActive(false);
            }

        }
    }
}
