using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{    
    public CharacterController controller;
    public CinemachineCamera cam;
    private Vector2 move;
    private Vector3 vel;
    public float speed = 10.0f;
    public float sprint = 17.0f;
    private float gravity = -9.8f; 
    public void OnMove(InputValue val)
    {
        move = val.Get<Vector2>();
    }

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Update()
    {
        vel.y += gravity * Time.deltaTime;
        controller.Move(vel * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move((Mforward() * move.y * sprint + MRight() * move.x * sprint) * Time.deltaTime);
        } else
        {
            controller.Move((Mforward() * move.y * speed + MRight() * move.x * speed) * Time.deltaTime);
        }
    }

    private Vector3 Mforward()
    {
        Vector3 forward = cam.transform.forward;
        forward.y = 0;

        return forward.normalized;
    }

    private Vector3 MRight()
    {
        Vector3 right = cam.transform.right;
        right.y = 0;

        return right.normalized;
    }
}
