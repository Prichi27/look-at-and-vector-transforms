using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTrigger : MonoBehaviour
{
    public Transform A;
    public Transform B;

    public float LookAtThreshold;

    private void OnDrawGizmos()
    {
        Vector2 objectToLookAt = B.position;
        Vector2 playerPos = A.position;
        Vector2 playerLookDirection =  A.right;

        Vector2 playerToObjectDir = (objectToLookAt - playerPos).normalized;

        float lookness = Vector2.Dot(playerToObjectDir, playerLookDirection);
        bool isLooking = lookness >= LookAtThreshold;

        Debug.Log(playerLookDirection);

        Gizmos.color = isLooking ? Color.red : Color.green;
        Gizmos.DrawLine(playerPos, playerPos + playerLookDirection);

        Gizmos.color = Color.white;
        Gizmos.DrawLine(playerPos, playerPos + playerToObjectDir);


        
    }
}
