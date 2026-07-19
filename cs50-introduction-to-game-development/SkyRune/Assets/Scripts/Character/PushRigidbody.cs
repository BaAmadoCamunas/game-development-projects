using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushRigidbody : MonoBehaviour
{

    #region Variables

    [Header("Push Variables")]
    public float pushPower = 2.0f;
    private float targetMass;

    #endregion


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;


        // Do nothing if the rigidbody is kinematic or if the object hasn't a rigidbody
        if(body == null || body.isKinematic)
        {
            return;
        }

        // Do nothing if the character falls down over a rigidbody
        if(hit.moveDirection.y < -0.3)
        {
            return;
        }

        targetMass = body.mass;


        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);


        // Push an object depending on its mass
        body.velocity = pushDir * pushPower / targetMass;
    }
}
