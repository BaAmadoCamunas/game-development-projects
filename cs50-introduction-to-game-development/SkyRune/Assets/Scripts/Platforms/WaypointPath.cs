using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPath : MonoBehaviour
{

    public Transform GetWaypoint(int waypoint)
    {
        return transform.GetChild(waypoint);
    }


    // Method for getting the next waypoint where the platform has to move to
    public int GetNextWaypoint(int currentWaypoint)
    {
        int nextWaypoint = currentWaypoint + 1;

        if(nextWaypoint == transform.childCount)
        {
            nextWaypoint = 0;
        }

        return nextWaypoint;
    }
}
