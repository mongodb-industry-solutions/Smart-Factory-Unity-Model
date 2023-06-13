using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class UIFacingPlayer : MonoBehaviour
{
    private Transform cameraTransform;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = cameraTransform.position + cameraTransform.forward * 5;
        transform.position = targetPosition;
        transform.LookAt(targetPosition + cameraTransform.rotation * Vector3.forward, cameraTransform.rotation * Vector3.up);
    }
}