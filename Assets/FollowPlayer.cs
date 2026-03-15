using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;      
    public Vector3 offset;        
    public float smoothSpeed = 5f; 

    void LateUpdate()
    {
        Vector3 targetPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothPosition;

        transform.LookAt(player); 
    }
}