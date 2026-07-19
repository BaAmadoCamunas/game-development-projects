using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{

    #region Variables

    [Header("Pick Up Objects Variables")]
    public GameObject ObjectToPickUp;
    public GameObject PickedObject;
    public Transform interactionZone;

    public AudioSource collectAudio;

    #endregion


    // Update is called once per frame
    void Update()
    {
        // Code for carrying small boxes if player press P key and it's not carrying anything in that moment
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<PickableObject>().isPickable == true && PickedObject == null)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                PickedObject = ObjectToPickUp;
                PickedObject.GetComponent<PickableObject>().isPickable = false;
                PickedObject.transform.SetParent(interactionZone);
                PickedObject.transform.position = interactionZone.position;

                // Make that physics don't affect the picked object
                PickedObject.GetComponent<Rigidbody>().useGravity = false;
                PickedObject.GetComponent<Rigidbody>().isKinematic = true;

                collectAudio.Play();
            }
        }
        // Code for dropping objects if player press P key again
        else if(PickedObject != null)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                PickedObject.GetComponent<PickableObject>().isPickable = true;
                PickedObject.transform.SetParent(null);

                // Make that physics affect the picked object again
                PickedObject.GetComponent<Rigidbody>().useGravity = true;
                PickedObject.GetComponent<Rigidbody>().isKinematic = false;

                PickedObject = null;

                collectAudio.Play();
            }
        }

    }
}
