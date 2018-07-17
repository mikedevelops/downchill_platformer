using UnityEngine;

public class FollowEntity : MonoBehaviour
{
    public Transform Target;
    public float Speed = 0.125f;
    public Vector2 Offset;

    private void Update()
    {
        Vector2 desiredPosition = new Vector2(Target.position.x, Target.position.y) + Offset;
        Vector2 smoothedPosition = Vector2.Lerp(transform.position, desiredPosition, Speed);
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }
}
