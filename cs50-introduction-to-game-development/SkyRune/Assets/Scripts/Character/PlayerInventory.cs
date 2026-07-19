using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    #region Variables

    [Header("Collectable Variables")]
    public int NumberOfGems { get; private set; }

    public bool BlueKey { get; private set; }
    public bool PurpleKey { get; private set; }
    public bool MoonKey { get; private set; }


    [Header("Collectable Events")]
    public UnityEvent<PlayerInventory> OnGemsCollected;
    public UnityEvent<PlayerInventory> OnBlueKeyCollected;
    public UnityEvent<PlayerInventory> OnPurpleKeyCollected;
    public UnityEvent<PlayerInventory> OnMoonKeyCollected;

    #endregion

    // Methods to invoke gems' events that increment the number of points depending on the gems value or that activate the portal
    public void GreenGemCollected()
    {
        NumberOfGems++;
        OnGemsCollected.Invoke(this);
    }

    public void BlueGemCollected()
    {
        NumberOfGems += 5;
        OnGemsCollected.Invoke(this);
    }

    public void RedGemCollected()
    {
        NumberOfGems += 20;
        OnGemsCollected.Invoke(this);
    }

    public void BlueKeyCollected()
    {
        BlueKey = true;
        OnBlueKeyCollected.Invoke(this);
    }

    public void PurpleKeyCollected()
    {
        PurpleKey = true;
        OnPurpleKeyCollected.Invoke(this);
    }

    public void MoonKeyCollected()
    {
        MoonKey = true;
        OnMoonKeyCollected.Invoke(this);
    }
}
