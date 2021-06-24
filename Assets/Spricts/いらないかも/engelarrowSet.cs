using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelarrowSet : MonoBehaviour
{
    [SerializeField] private GameObject Arrow;

    private void OnTriggerStay2D(Collider2D collision)
    {
        StartCoroutine("SetArrow");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        StopCoroutine("SetArrow");
        Debug.Log("こるこるるんるん");
    }

    IEnumerator SetArrow()
    {
        Instantiate(Arrow);
        yield return new WaitForSeconds(5);
    }
}
