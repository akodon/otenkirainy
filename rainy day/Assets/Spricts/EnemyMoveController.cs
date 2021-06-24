using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveController : MonoBehaviour
{
    [SerializeField]EnemyController enemycontroller;

    public Move move;

    private int count;
   [SerializeField] private float Speed = 1;

    public void SetTargetIn() {
        move = new TargetInMove();
    }

    public void SetTargetOut() {
        move = new TargetOutMove();
    }

    private void Update()
    {

      //  move.DoMove(count,Speed,this.transform);

        if (enemycontroller.targetin == true)
        {
         

        }

        else if (enemycontroller.targetin == false)
        { 


            count += 1;
            //往復する
            transform.Translate(Speed * Vector2.left * Time.deltaTime);

            if (count == 200)
            {
                count = 0;
                transform.Rotate(0, 180, 0);
            }


        }
    }






 
}
