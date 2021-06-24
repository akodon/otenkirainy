using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindrop : MonoBehaviour
{
    [SerializeField] GameObject rain;
    [SerializeField] private float Min_x;
    [SerializeField] float Max_x;
    [SerializeField] int waittime = 5;
    [SerializeField] int rainytime = 10;
    private float vec_x;

    

    private void Start()
    {
        StartCoroutine(Createobject());
    }

    IEnumerator Createobject()
    {
        while (true)
        {
            //30秒作るコルーチンを待つ
            yield return CreateSecond(rainytime);
            yield return new WaitForSeconds(waittime);
        }
    }
    IEnumerator CreateSecond(int lefttime)
    {
        //秒が立つまでループする
        while (lefttime >= 0)
        {
            //残りの時間が0以上の場合はタイマーを更新
            yield return new WaitForSeconds(1.0f);

            --lefttime;
            //ランダムの変数を設定
            vec_x = UnityEngine.Random.Range(Min_x, Max_x);
            //GameObjectをランダムに生成
            GameObject Rain = Instantiate(rain, 
                new Vector2(transform.position.x + vec_x, this.gameObject.transform.position.y), Quaternion.identity);
            Rain.transform.SetParent(transform);

        }
        yield return null;
    }

}
