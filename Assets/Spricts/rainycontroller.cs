using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainycontroller : MonoBehaviour
{
   public Rainfall rainfall;
    [SerializeField] GameObject NoticeImage;

   [SerializeField] GameObject Arain;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        //playerのタグが通ったら
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("とお");
            //Fallを2秒後に呼びだす
            Invoke("Fall",2);
            NoticeImage.SetActive(true);
            Arain.SetActive(false);
            Invoke("Notice", 32);
            Invoke("Rain",30);
        }
    }

    
    void Fall()
    {
        rainfall.Fall();
    }

    void Rain()
    {
        Arain.SetActive(true);
    }

   void Notice()
    {
        NoticeImage.SetActive(false);
    }


}
