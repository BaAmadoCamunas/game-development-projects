using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class InventoryUI : MonoBehaviour
{

    #region Variables

    [Header("Level UI Variables")]
    private TextMeshProUGUI gemsText;
    [SerializeField] private GameObject blueKeyIcon;
    [SerializeField] private GameObject blueKeyIconActivate;
    [SerializeField] private GameObject purpleKeyIcon;
    [SerializeField] private GameObject purpleKeyIconActivate;
    [SerializeField] private GameObject moonKeyIcon;
    [SerializeField] private GameObject moonKeyIconActivate;

    [SerializeField] private GameObject finishLevel;
    [SerializeField] private GameObject finishLevel_rock;


    public bool Blue_Key = false;
    public bool Purple_Key;
    public bool Moon_Key;


    public AudioSource collectAudio;

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        if (this.tag == "GemsText")
        {
            gemsText = GetComponent<TextMeshProUGUI>();
        }

        if(this.tag == "BlueKeyIcon")
        {
            blueKeyIcon.SetActive(true);
            blueKeyIconActivate.SetActive(false);
        }

        if(this.tag == "PurpleKeyIcon")
        {
            purpleKeyIcon.SetActive(true);
            purpleKeyIconActivate.SetActive(false);
        }

        if (this.tag == "MoonKeyIcon")
        {
            moonKeyIcon.SetActive(true);
            moonKeyIconActivate.SetActive(false);
        }

    }


    // Update the game text depending on the number of gems that player has
    public void UpdateGemsText(PlayerInventory playerInventory)
    {
        gemsText.text = playerInventory.NumberOfGems.ToString();
    }

    // Activate the Blue Key icon in the Level UI and the portal in some levels (Level 1 and 4)
    public void UpdateBlueKey(PlayerInventory playerInventory)
    {
        blueKeyIcon.SetActive(false);
        blueKeyIconActivate.SetActive(true);
        Blue_Key = true;

        if(finishLevel.tag == "FinishLevel_1")
        {
            finishLevel_rock.SetActive(true);
            collectAudio.Play();

        }
        else if (finishLevel.tag == "FinishLevel_4")
        {
            finishLevel_rock.SetActive(true);
            collectAudio.Play();
        }

    }

    // Activate the Purple Key icon in the Level UI and the portal in some levels (Level 2 and 4)
    public void UpdatePurpleKey(PlayerInventory playerInventory)
    {
        purpleKeyIcon.SetActive(false);
        purpleKeyIconActivate.SetActive(true);
        Purple_Key = true;

        if (finishLevel.tag == "FinishLevel_2")
        {
            finishLevel_rock.SetActive(true);
            collectAudio.Play();
        }
        else if (finishLevel.tag == "FinishLevel_4")
        {
            finishLevel_rock.SetActive(true);
            collectAudio.Play();
        }
    }

    // Activate the Moon Key icon in the Level UI and the portal in some levels (Level 3 and 4)
    public void UpdateMoonKey(PlayerInventory playerInventory)
    {
        moonKeyIcon.SetActive(false);
        moonKeyIconActivate.SetActive(true);
        Moon_Key = true;

        if (finishLevel.tag == "FinishLevel_3")
        {
            finishLevel_rock.SetActive(true);
            collectAudio.Play();
        }
        else if (finishLevel.tag == "FinishLevel_4")
        {
            finishLevel_rock.SetActive(true);
            collectAudio.Play();
        }
    }

}
