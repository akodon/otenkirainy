using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rain : MonoBehaviour
{
    private playerController PC;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground"||collision.gameObject.tag == "Player"
            ||collision.gameObject.tag=="damegeGround"||collision.gameObject.tag=="Deadwall"
            ||collision.gameObject.tag=="cloudyGround")
        {
            Destroy(gameObject);
        }



    }

}
