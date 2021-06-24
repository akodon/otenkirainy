using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpController : MonoBehaviour
{
   public UnityEvent OnEnterGround;

     public UnityEvent OnExitGround;

     private int isJump ;
     private void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision.gameObject.tag == "Ground"||
             collision.gameObject.tag=="DamegeGround"||
             collision.gameObject.tag=="cloudyGround")
         {
             Debug.Log("Onground");
             isJump++;
             OnEnterGround.Invoke();
         }

     }
     private void OnTriggerExit2D(Collider2D collision)
     {
         Debug.Log("ExitGround");
         isJump--;
         if (isJump<=0)
         {
             OnEnterGround.Invoke();
         }

     }
}
