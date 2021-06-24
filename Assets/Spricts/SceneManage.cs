using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
   
    public void ToFristGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Tototle()
    {
        SceneManager.LoadScene("title");
    }
    public void Tokirikae()
    {

        Invoke("ToGame", 2f);
    }
    public void ToGame()
{
        SceneManager.LoadScene("SampleScene");
    }

    public void ToSecondGame()
    {
        SceneManager.LoadScene("Strage2Scene");
    }

    public void ToThirdGame()
    {
        SceneManager.LoadScene("starge3Scene");
    }

    public void ToStoryScene()
    {
        SceneManager.LoadScene("StoryScene");
    }
}
