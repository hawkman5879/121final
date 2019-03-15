using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterMotor : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 5.0f;
    public float gravity = 5.0f;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    public CursorLockMode cursorLockMode = CursorLockMode.Locked;
    public bool cursorVisible = false;
    [Header("Look")]
    public Transform cameraPivot;
    public float lookSpeed = 45;
    public bool invertY = true;
    Quaternion targetRotation, targetPivotRotation;

    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    void Update()
    {
        UpdateLookRotation();
        UpdateMove();
    }
    void UpdateMove()
    {
        if (controller.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes
            Debug.Log("We here?");
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;
            // Apply gravity
            moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

            // Move the controller
            controller.Move(moveDirection * Time.deltaTime);

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
    }
    void UpdateLookRotation()
    {
        var x = Input.GetAxis("Mouse Y");
        var y = Input.GetAxis("Mouse X");

        x *= invertY ? -1 : 1;
        targetRotation = transform.localRotation * Quaternion.AngleAxis(y * lookSpeed * Time.deltaTime, Vector3.up);
        targetPivotRotation = cameraPivot.localRotation * Quaternion.AngleAxis(x * lookSpeed * Time.deltaTime, Vector3.right);

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, Time.deltaTime * 15);
        cameraPivot.localRotation = Quaternion.Slerp(cameraPivot.localRotation, targetPivotRotation, Time.deltaTime * 15);
    }
}
