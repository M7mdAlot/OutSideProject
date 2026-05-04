using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovementScript : MonoBehaviour
{
    public float Speed = 5f;
    public Transform Camera;
    public int JumpLimit = 2;
    public int JumpCount = 1;
    public float JumpForce = 10;
    public Vector3 velocity;
    public float Gravity = -9.8f;
    public bool IsGrounded;
    public CharacterController characterController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible=false;
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = characterController.isGrounded;

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        if (Horizontal != 0 || Vertical != 0)
        {
            transform.rotation = Quaternion.Euler(0f, Camera.eulerAngles.y, 0);
        }
        Vector3 CharaMove = transform.right*Horizontal+transform.forward*Vertical;
        characterController.Move(CharaMove * Time.deltaTime*Speed);
        if (IsGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }
        if ( Input.GetButtonDown("Jump")&& JumpCount<JumpLimit)
        {
            if (!IsGrounded && JumpCount == 0)
            {
                JumpCount++;
            }
            velocity.y = Mathf.Sqrt(  JumpForce* -2f * Gravity);
            JumpCount++;
            

        }
        if (IsGrounded && !Input.GetButtonDown("Jump")) { JumpCount = 0; }
        velocity.y += Gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);

    }
    private void FixedUpdate()
    {

       
    }
}
