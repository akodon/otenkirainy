using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOutMove :  Move
{
    void Move.DoMove(int count, float Speed,Transform transform)
    {
        //往復する
        transform.Translate(Speed * Vector2.left * Time.deltaTime);

        if (count == 200)
        {
            count = 0;
            transform.Rotate(0, 180, 0);
        }
    }
}
