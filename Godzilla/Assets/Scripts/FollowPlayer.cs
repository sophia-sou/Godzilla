using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform godzilla;
    public Vector3 offset;

    void Update()
    {
        if (godzilla != null)
        {
            transform.position = godzilla.position + offset;
        }
    }
}
