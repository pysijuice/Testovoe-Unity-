using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject wolf;
    [SerializeField] Vector3 distance;

    private void LateUpdate()
    {
        transform.position = wolf.transform.position + distance;
    }
}
