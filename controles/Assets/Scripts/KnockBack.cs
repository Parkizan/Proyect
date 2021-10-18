using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    [SerializeField] private float knockbackStrength;
    float time = 8;

    //public  Rigidbody rb;
    private CharacterController ch;

    //private Animator animator;

    private void OnTriggerStay(Collider collision){
   
        if(Input.GetKeyDown("e") && collision.gameObject.tag == "Player"){

            //rb = collision.gameObject.GetComponent<Rigidbody>();

            ch = collision.gameObject.GetComponent<CharacterController>();

            Vector3 direccion = collision.transform.position - transform.position;
            direccion.y = 0;

            FindObjectOfType<AudioManager>().Play("KnockBack");

            ch.SimpleMove(direccion.normalized * knockbackStrength);

           //animator = collision.gameObject.GetComponent<Animator>();
           //animator.SetBool("Impacto", true);

            //ch.Move(direccion.normalized * knockbackStrength);

            //rb.AddForce(direccion.normalized * knockbackStrength, ForceMode.Impulse);
            //rb.AddForce(-direccion.normalized * knockbackStrength);
        }
    }

    public void KnockBackBuff()
    {
       StartCoroutine(Buff());

      IEnumerator Buff(){
        knockbackStrength = 100;
        WaitForSeconds wait = new WaitForSeconds(time);
        yield return wait;
        knockbackStrength = 50; 
        }
    }
}
