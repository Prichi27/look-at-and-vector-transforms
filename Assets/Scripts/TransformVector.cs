using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformVector : MonoBehaviour
{
    public Vector2 localPosition;
    private void OnDrawGizmos()
    {

        Gizmos.color = Color.red;
        // World's x axis
        Gizmos.DrawRay(Vector2.zero, Vector2.right);

        // Transform's local x axis
        Gizmos.DrawRay(transform.position, transform.right);

        Gizmos.color = Color.green;
        // World's x axis
        Gizmos.DrawRay(Vector2.zero, Vector2.up);

        // Transform's Y axis
        Gizmos.DrawRay(transform.position, transform.up);

        // Draw position local to current transform
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(LocalToWorldPos(localPosition), 0.2f);
    }

    private Vector2 LocalToWorldPos(Vector2 localPosition)
    {
        Vector2 worldOffset = transform.right * localPosition.x + transform.up * localPosition.y;
        return (Vector2) transform.position + worldOffset;
    }
}
