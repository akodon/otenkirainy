using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaionrope : MonoBehaviour
{
    [SerializeField] float Rotationspeed;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0,Rotationspeed));
    }
}
