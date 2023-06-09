using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using System.Linq;

public class PlayerControls : MonoBehaviour
{
    private InputDevice leftController;

    // public Camera MainCamera;

    public float moveSpeed = 0.3f;
    
    // Start is called before the first frame update
    void Start()
    {
        var leftHandDevice = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, leftHandDevice);
        leftController = leftHandDevice.FirstOrDefault();
    }

    // Update is called once per frame
    void Update()
    {
        if (leftController != null)
        {
            // Get joystick movement
            if (leftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 joystick))
            {
                float horizontalMovement = joystick.x;
                float verticalMovement = joystick.y;
                
                // Transforming the vector to local space. so when passed to the transform.Translate, it's all converted to local
                Vector3 lookingForward = Camera.main.transform.forward;
                Vector3 lookingRight = Camera.main.transform.right;

                lookingForward.y = 0;
                lookingRight.y = 0;

                lookingForward = lookingForward.normalized;
                lookingRight = lookingRight.normalized;

                float speedChange = 0.3f;

                Vector3 forwardRelativeVerticalInput = (verticalMovement * lookingForward);
                Vector3 rightRelativeHorizontalInput = (horizontalMovement * lookingRight);

                Vector3 cameraRelativeMovement = (forwardRelativeVerticalInput + rightRelativeHorizontalInput) * speedChange;

                transform.Translate(cameraRelativeMovement, Space.World);


                // Move the camera based on input
                // Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement) * moveSpeed * Time.deltaTime;
                // transform.Translate(movement);
            }
        }
    }
}
