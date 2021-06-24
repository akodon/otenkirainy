using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuAnimation : MonoBehaviour
{

    public void ToAnimation()
    {
        this.transform.DOLocalMoveY(0, 1f);
    }

    public void ToReturn()
    {
        this.transform.DOLocalMoveY(455, 1f);
    }
}
