using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TargetArrow : MonoBehaviour
{
    public UnityEvent AngelTargeton;

    public UnityEvent AngelTargetoff;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            AngelTargeton.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AngelTargetoff.Invoke();
        }
        
    }
}
