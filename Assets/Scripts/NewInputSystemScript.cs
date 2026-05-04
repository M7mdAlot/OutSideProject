using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class NewInputSystemScript : MonoBehaviour
{
    public float Speed = 5f;
    //public Transform Camera;
    public float Rotation;
    /*public int JumpLimit = 2;
    public int JumpCount = 0;
    public float JumpForce = 10;*/
    public Vector3 velocity;
    public float Gravity = -9.8f;
    public bool IsGrounded;
    public Animator animator;
    public CharacterController characterController;
    public Vector2 MoveInput;
    public Vector2 LookInput;
    public bool Forward=false;
    public bool Backward = false;

    //public bool IsDashing=false;
    //float AirDash = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        IsGrounded = characterController.isGrounded;
       
        float Horizontal = LookInput.x;
        float Vertical = MoveInput.y;
        /*camForward.y = 0f;
        camRight.y = 0f;
        camForward.Normalize();
        camRight.Normalize();*/
        if (Vertical>0)
        {

           animator.SetBool("Forward", true);
            animator.SetBool("Backward", false);

        }
        if (Vertical == 0)
        {

            animator.SetBool("Forward", false);
            animator.SetBool("Backward", false);


        }
        if (Vertical < 0)
        {

            animator.SetBool("Forward", false);
            animator.SetBool("Backward", true);


        }
        Debug.Log(Vertical);
        Vector3 CharaMove =  transform.forward * Vertical;
        Vector3 moveD = transform.right * Horizontal;

        characterController.Move(CharaMove * Time.deltaTime * Speed);
        if (!IsGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }

      /*  if (IsGrounded && !Input.GetButtonDown("Jump"))
        {
            JumpCount = 0;
            AirDash = 0;
        }*/
        velocity.y += Gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);

        if (Horizontal != 0)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveD);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Rotation * Time.deltaTime);
        }
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }

    public void OnLook (InputAction.CallbackContext context)
    {
        LookInput = context.ReadValue<Vector2>();
    }
    /*  public void OnJump(InputAction.CallbackContext context)
      {
          if (context.started)
          {
              if (JumpCount < JumpLimit)
              {

                  if (!IsGrounded && JumpCount == 0)
                  {
                      JumpCount++;
                  }
                  velocity.y = Mathf.Sqrt(JumpForce * -2f * Gravity);
                  JumpCount++;
              }
          }
      }
      public void OnDash(InputAction.CallbackContext context)
      {
          if (context.started&&!IsDashing)
          {
              StartCoroutine(Dash());

          }
      }
      IEnumerator Dash()
      {
          if (IsDashing) yield break;
          IsDashing = true;
          float dashSpeed = 20f;
          float dashDuration = 0.2f;
          float elapsed = 0f;
          float AirDashLimit = 1f;
          float DashCoolDown = 0.8f;
          if (!characterController.isGrounded && AirDash < AirDashLimit)
          {
              while (elapsed < dashDuration)
              {
                  characterController.Move(transform.forward * dashSpeed * Time.deltaTime);
                  elapsed += Time.deltaTime;
                  yield return null;

              }
              AirDash++;

          }
          if (characterController.isGrounded)
          {
              while (elapsed < dashDuration)
              {
                  characterController.Move(transform.forward * dashSpeed * Time.deltaTime);
                  elapsed += Time.deltaTime;
                  yield return null;
              }

          }
          yield return new WaitForSeconds(DashCoolDown);
          IsDashing = false;
      }
      public void OnSprint(InputAction.CallbackContext context)
      {
          if (context.started)
          {
              Speed = Speed * 2;
          }
          if (context.canceled)
          {
              Speed = Speed / 2;
          }
      }*/
    public void Interact(InputAction.CallbackContext context)
    {
        if (context.started)
        {
        }
    }
    public void Uninteract(InputAction.CallbackContext context)
    {
        if (context.started)
        {
        }
    }
}
