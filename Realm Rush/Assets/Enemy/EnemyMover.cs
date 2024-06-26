using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{   

    //list is infinite(mutable) array kind of 

    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitTime = 1f;

    void Start()
    {   
        
        StartCoroutine(FollowPath());
        
        
    }

    IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path)
        {   
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waitTime); 
        }
    }

    
}
