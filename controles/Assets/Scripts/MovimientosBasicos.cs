using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MovimientosBasicos : MonoBehaviour
{
    public CharacterController cuntroles;
    public float spEed = 5;
    private Vector3 movementInput;
     Vector3 moveVector;

     [SerializeField] float time = 8;

    [SerializeField] KeyCode uparrow;
    
    [SerializeField] KeyCode downarrow;
    
    [SerializeField] KeyCode rightarrow;
    
    [SerializeField] KeyCode leftarrow;

    public float TurnSmoothTime = 0.001f;
    float TurnSmoothVelocity;


 float horizontal = 0;
   float vertical = 0;
    private void Update()
    {




      if (Input.GetKeyDown(uparrow)){
         switch (vertical){
            case 1:
              break;
            case 0:
              vertical = 1;
              break;
            case -1:
              vertical = 0;
              break;
         }
      }

       else if (Input.GetKeyUp(uparrow)){
        switch (vertical){
            case 1:
              vertical = 0;
              break;
            case 0:
            vertical = 0;            
              break;
            case -1:
            vertical = 0;
              break;
        }
      }

      if (Input.GetKeyDown(downarrow)){
         switch (vertical){
            case 1:
              vertical = 0;
              break;
            case 0:
              vertical = -1;
              break;
            case -1:
              break;
         }
      } else if (Input.GetKeyUp(downarrow)){
        switch (vertical){
            case 1:
             
              break;
            case 0:
            vertical = 0;            
              break;
            case -1:
            vertical = 0;
              break;
        }
      }

            if (Input.GetKeyDown(rightarrow)){
         switch (horizontal){
            case 1:
              break;
            case 0:
              horizontal = 1;
              break;
            case -1:
              horizontal = 0;
              break;
         }
      }
       else if (Input.GetKeyUp(rightarrow)){
        switch (horizontal){
            case 1:
              horizontal = 0;
              break;
            case 0:            
              break;
            case -1:
              horizontal = 0;
              break;
        }
      }

            if (Input.GetKeyDown(leftarrow)){
         switch (horizontal){
            case 1:
              horizontal = 0;
              break;
            case 0:
              horizontal = -1;
              break;
            case -1:
              break;
         }
      }
      else if (Input.GetKeyUp(leftarrow)){
        switch (horizontal){
            case 1:
              horizontal = 0;
              break;
            case 0:
             horizontal = 0;          
              break;
            case -1:
             horizontal = 0;
              break;
        }
      }




      Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

      if(direction.magnitude >= 0.1f)
      {
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        //NO ES IMPOSTOR!!!
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref TurnSmoothVelocity, TurnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);

          cuntroles.Move(direction * spEed * Time.deltaTime);
          //transform.Translate(new Vector3(, 0, ) * spEed * Time.deltaTime);
      }

      moveVector = Vector3.zero;

      if (cuntroles.isGrounded == false)
         {
             moveVector += Physics.gravity;
         }
 
         cuntroles.Move(moveVector * Time.deltaTime);

        
    }
    public void OnMove(InputAction.CallbackContext ctx) => movementInput = ctx.ReadValue<Vector3>();

    public void SpeedUp()
    {
      StartCoroutine(GottaGoFast());

      IEnumerator GottaGoFast(){
        spEed = 10;
        WaitForSeconds wait = new WaitForSeconds(time);
        yield return wait;
        spEed = 5;  
    }
    }

    public void SpeedDown()
    {
      StartCoroutine(GottaGoSlow());

      IEnumerator GottaGoSlow(){
        spEed = 2;
        WaitForSeconds wait = new WaitForSeconds(time);
        yield return wait;
        spEed = 5;  
    }
    }

}
