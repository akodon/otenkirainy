using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TeardropAC : MonoBehaviour
{
   
    public void TearAnimation()
    {
        this.transform.DOMoveY(10, 1f);
    }
   
}
