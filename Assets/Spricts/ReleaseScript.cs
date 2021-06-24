using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseScript : MonoBehaviour
{

    [SerializeField] private int stageNum;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            //PlayerPrefsのSCOREに3という値を入れる
            PlayerPrefs.SetInt("SCORE", stageNum);

            //PlayerPrefsをセーブする
            PlayerPrefs.Save();

            Debug.Log(stageNum);
        }
    }
}
