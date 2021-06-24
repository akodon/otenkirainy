using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
   
    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x, 0, -10);

        if (transform.position.x < 0)
        {
            transform.position = new Vector3(0, 0, -10);
        }

       
    }

 
}
