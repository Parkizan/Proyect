using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientosViejos : MonoBehaviour
{
    public CharacterController cuntroles;

    public float spEed = 6f;

    Vector3 moveVector;

    public float TurnSmoothTime = 0.001f;
    float TurnSmoothVelocity;

    void Update()
    {
      float horizontal = Input.GetAxisRaw("Horizontal");
      float vertical = Input.GetAxisRaw("Vertical");
      Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

      if(direction.magnitude >= 0.1f)
      {
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        //NO ES IMPOSTOR!!!
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref TurnSmoothVelocity, TurnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);

          cuntroles.Move(direction * spEed * Time.deltaTime);
      }

      moveVector = Vector3.zero;

      if (cuntroles.isGrounded == false)
         {
             moveVector += Physics.gravity;
         }
 
         cuntroles.Move(moveVector * Time.deltaTime);
    }
}
