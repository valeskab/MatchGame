using System;
using UnityEngine;

public class TransformComponent : MonoBehaviour
{
    public void ResetToZero()
    {
        transform.position = Vector3.zero;
    }
}
