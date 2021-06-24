using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popuptext : MonoBehaviour
{
    [SerializeField] GameObject poptest;

    private void OnTriggerStay2D(Collider2D collision)
    {
        poptest.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        poptest.SetActive(false);
    }
}
