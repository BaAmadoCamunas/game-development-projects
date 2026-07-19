using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    #region Variables

    [Header("Pickable Objects Variables")]
    public bool isPickable = true;


    #endregion


    // Method to let the player pick up small boxes if the invisible playerInteractionZone is colliding with that type of boxes
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerInteractionZone")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = this.gameObject;
        }
    }

    // Method to let the player drop small boxes if the player is carrying one of that boxes
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "PlayerInteractionZone")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = null;
        }
    }
}
