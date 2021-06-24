using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lifecontroller : MonoBehaviour
{
    private Renderer renderer;
    
    public float HP;
    public float maxHP;
    public float RainDamage = 10;
    public float wallDamage = 5;
    public GameObject damageeffect;

    [SerializeField] Slider slider;
    [SerializeField] Text HPtext;
    [SerializeField] GameObject GameOverCanvas;
    [SerializeField]GameObject GameClearCanvas;

    private void Start()
    {
        GameOverCanvas.SetActive(false);

        renderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      

        if (other.gameObject.tag == "damegezako")
        {
            HP -= wallDamage;
            if (HP <= 0)
            {
                Dead();

            }
        }

        if (other.gameObject.tag == "Deadwall")
        {
            Debug.Log("しねぇ！！");
            Dead();
        }

        if (other.gameObject.tag == "GameClear")
        {
            gameClear();
        }

        HPCanvas();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Rain")
        {
            HP -= RainDamage;
            StartCoroutine("Damage");
            foreach (ContactPoint2D point in collision.contacts)
            {
                GameObject effect = Instantiate(damageeffect) as GameObject;
                effect.transform.position = (Vector2)point.point;
            }



            if (HP <= 0)
            {
                Dead();

            }
        }


        if (collision.gameObject.tag == "damegeGround")
        {
            HP -= wallDamage;
          
        }

        if (HP <= 0)
        {
            Dead();
        }

        HPCanvas();
    }

    IEnumerator Damage()
    {
        //レイヤーをPlayerDamageに変更
        gameObject.layer = LayerMask.NameToLayer("PlayerDamage");

        //while文を10回ループ
        int count = 3;

        while (count > 0)
        {
            //透明にする
            renderer.material.color = new Color(1, 1, 1, 0);

            //0.1秒待つ
            yield return new WaitForSeconds(0.2f);

            //元に戻す
            renderer.material.color = new Color(1, 1, 1, 1);

            //0.3秒待つ
            yield return new WaitForSeconds(0.3f);

            count--;
        }

        gameObject.layer = LayerMask.NameToLayer("Player");
    }

    void HPCanvas()
    {
        HPtext.text = HP + "/" + maxHP;
        slider.value = HP;
    }
    public void Dead()
    {
        GameOverCanvas.SetActive(true);
    }
    public void gameClear()
    {
        GameClearCanvas.SetActive(true);
        /*試しにここに書けば何かあるんじゃないかと思いったった所存*/
    }
}
