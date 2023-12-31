using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationController : MonoBehaviour
{
    public GameObject targetObject;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        float horizontalRotation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");

        transform.RotateAround(targetObject.transform.position, Vector3.up, horizontalRotation * rotationSpeed * Time.deltaTime);
        transform.RotateAround(targetObject.transform.position, Vector3.right, verticalRotation * rotationSpeed * Time.deltaTime);

        // Ensure the camera always looks at the target
        transform.LookAt(targetObject.transform);
    }
    //targetObject=GameManager.Instance.CharacterController.umaAvatar.gameObject;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            float horizontalRotation = Input.GetAxis("Mouse X");
            float verticalRotation = Input.GetAxis("Mouse Y");

            transform.RotateAround(targetObject.transform.position, Vector3.up, horizontalRotation * rotationSpeed * Time.deltaTime);
            transform.RotateAround(targetObject.transform.position, Vector3.right, verticalRotation * rotationSpeed * Time.deltaTime);

            // Ensure the camera always looks at the target
            transform.LookAt(targetObject.transform);
        }
    }
}
