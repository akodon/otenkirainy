using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool targetin = false;
    [SerializeField] private GameObject[] hukidasi;



    private void Start()
    {
        targetin = false;

            hukidasi[0].SetActive(false);
            hukidasi[1].SetActive(false);
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            targetin = true;
            hukidasi[0].SetActive(true);
            hukidasi[1].SetActive(false);


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            targetin = false;

            hukidasi[0].SetActive(false);
            hukidasi[1].SetActive(false);

        }

    }
    private void hukidasipopup()
    {
        hukidasi[0].SetActive(false);
        hukidasi[1].SetActive(true); 
    }

    private void hukidasipopout()
    {
        hukidasi[0].SetActive(true);
        hukidasi[1].SetActive(false);  
    }
}
