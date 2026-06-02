using UnityEngine;

public class LocalPlayer : MonoBehaviour
{
    [Header("头部")]
    public Transform Head;

    [Header("左手")]
    public Transform LeftHand;

    [Header("右手")]
    public Transform RightHand;

    public Vector3 GetHeadPosition()
    {
        return Head.position;
    }

    public Quaternion GetHeadRotation()
    {
        return Head.rotation;
    }

    public Vector3 GetLeftHandPosition()
    {
        return LeftHand.position;
    }

    public Vector3 GetRightHandPosition()
    {
        return RightHand.position;
    }
}