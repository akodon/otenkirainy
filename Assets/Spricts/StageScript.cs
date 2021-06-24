using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript : MonoBehaviour
{
    public int stage_num;
    public GameObject nomal;
    public GameObject hard;
    public GameObject story;
   

    void Start()
    {
        //現在のstage_numを呼び出す
        stage_num = PlayerPrefs.GetInt("SCORE");
        
    }

    
    void Update()
    {
        //stage_numが2以上の時、ステージを開放する
        if (stage_num >= 2)
        {
            nomal.SetActive(true);
        }
       if (stage_num >= 3)
        {
            hard.SetActive(true);
        }
       if (stage_num >= 4)
        {
            story.SetActive(true);
        }
        if (stage_num == 0)
        {
            nomal.SetActive(false);
            hard.SetActive(false);
            story.SetActive(false);
        }
    }

    public void ScoreReset()
    {
        stage_num = 0;
        Debug.Log(stage_num);
    }
}
