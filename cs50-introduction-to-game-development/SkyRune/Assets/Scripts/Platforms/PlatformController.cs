using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    #region Variables

    public WaypointPath waypointPathObject;
    public float platformSpeed;
    private int targetWaypointIndex;

    private Transform previousWaypoint;
    private Transform targetWaypoint;
    private float timeToWaypoint;
    private float elapsedTime;

    #endregion


    private void Start()
    {
        TargetNextWaypoint();
    }

    private void FixedUpdate()
    {
        // Make the platform slower when is near to the next waypoint
        elapsedTime += Time.deltaTime;

        float elapsedPercentage = elapsedTime / timeToWaypoint;

        elapsedPercentage = Mathf.SmoothStep(0, 1, elapsedPercentage);

        // Make platform to change its position and rotation depending on the position and rotation of the next target
        transform.position = Vector3.Lerp(previousWaypoint.position, targetWaypoint.position, elapsedPercentage);
        transform.rotation = Quaternion.Lerp(previousWaypoint.rotation, targetWaypoint.rotation, elapsedPercentage);

        if (elapsedPercentage >= 1)
        {
            TargetNextWaypoint();
        }
    }

    // If the platform is over the target, change the next target
    private void TargetNextWaypoint()
    {
        previousWaypoint = waypointPathObject.GetWaypoint(targetWaypointIndex);
        targetWaypointIndex = waypointPathObject.GetNextWaypoint(targetWaypointIndex);
        targetWaypoint = waypointPathObject.GetWaypoint(targetWaypointIndex);

        elapsedTime = 0;

        float waypointDistance = Vector3.Distance(previousWaypoint.position, targetWaypoint.position);
        timeToWaypoint = waypointDistance / platformSpeed;
    }


    // Let the player moves with the platform
    private void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(transform);
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
    }
}
