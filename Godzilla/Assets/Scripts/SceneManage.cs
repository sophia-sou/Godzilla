using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEditor.Build.Content;

public class SceneManage : MonoBehaviour
{
    public Text ScoreText;
    public Button Button;

    private float startTime;
    private float LastGameScore = 0f;

    private void Start()
    {
    //  LastGameScore = GameManager.Instance.GetLastGameScore();
        startTime = Time.realtimeSinceStartup;
       //isplayBestScores();
    //  Button.onClick.AddListener(OnButtonClick);
    }
}
