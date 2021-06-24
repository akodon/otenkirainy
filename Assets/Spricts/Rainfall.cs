using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainfall : MonoBehaviour
{
    [SerializeField] GameObject rain;
    public float Min_x = -5f;
    public float Max_x = 5f;
    private float vec_x;



    public void Fall()
    {
        
        //スタート
        StartCoroutine("tsettimer", 30);


    }
    
    
    IEnumerator tsettimer(int lefttime)
    {
        

        //30秒が立つまでループする
        while (lefttime >= 0)
        {
            //残りの時間が0以上の場合はタイマーを更新
            yield return new WaitForSeconds(1.0f);
           
            --lefttime;
                //ランダムの変数を設定
                vec_x = Random.Range(Min_x, Max_x);
                //GameObjectをランダムに生成
                GameObject Rain = Instantiate(rain, new Vector2(transform.position.x + vec_x, this.gameObject.transform.position.y), Quaternion.identity);
            Rain.transform.SetParent(transform);
            

        }
        
    }

}
