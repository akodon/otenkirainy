using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class TextController : MonoBehaviour
{
    public string[] scenarios;
    [SerializeField] Text uiText;

    [SerializeField]
    [Range(0.001f, 0.3f)]
    float intervalForCharacterDisplay = 0.05f;

    [SerializeField] GameObject FeardoutPanel;

    [SerializeField]int Lastuitext;
    [SerializeField] float WaitTime;



    private string currentText = string.Empty;
    private float timeUntilDisplay = 0;
    private float timeElapsed = 1;
    private int currentLine = 0;
    private int lastUpdateCharacter = -1;

    // 文字の表示が完了しているかどうか
    public bool IsCompleteDisplayText
    {
        get { return Time.time > timeElapsed + timeUntilDisplay; }
    }


    void Start()
    {
        FeardoutPanel.SetActive(false);
        SetNextLine();

    }

    void Update()
    {
        // 文字の表示が完了してるならクリック時に次の行を表示する
        if (IsCompleteDisplayText)
        {
            if (currentLine < scenarios.Length && Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Return))
            {
                SetNextLine();
            }
        }
        else
        {
            // 完了してないなら文字をすべて表示する
            if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Return))
            {
                timeUntilDisplay = 0;
            }
            
        }

        int displayCharacterCount = (int)(Mathf.Clamp01((Time.time - timeElapsed) / timeUntilDisplay) * currentText.Length);
        if (displayCharacterCount != lastUpdateCharacter)
        {
            uiText.text = currentText.Substring(0, displayCharacterCount);
            lastUpdateCharacter = displayCharacterCount;
        }


        
    }

    //次の分を表示する
    void SetNextLine()
    {
        currentText = scenarios[currentLine];
        timeUntilDisplay = currentText.Length * intervalForCharacterDisplay;
        timeElapsed = Time.time;
        currentLine++;
        lastUpdateCharacter = -1;
        Debug.Log(currentLine);

        if (currentLine == Lastuitext)
        {
            FeardoutPanel.SetActive(true);

            Invoke("Totitle", WaitTime);
            
        }

    }

    void Totitle()
    {
        SceneManager.LoadScene("title");
    }

    //SuocreTreeの試しガキ


}
