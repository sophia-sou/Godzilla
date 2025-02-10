using UnityEngine;
using TMPro;
using TMPro.Examples;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float countdownTime;
    private float remainingTime;
    public GameObject skullPrefab;
    public GameObject Godzilla;

    private int prevScene = GodzillaHealth.previousSceneIndex;
    public static float scoreLevel01;
    public static float scoreLevel02;
    public static float scoreLevel03;

    private void Start()
    {
        remainingTime = countdownTime;  
    }
    private void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;

            Vector3 godzillaPosition = Godzilla.transform.position;
            GameObject skull = Instantiate(skullPrefab, godzillaPosition, Quaternion.identity);
            Destroy(Godzilla);
            Destroy(skull, 2f);

            SceneManager.LoadScene("GameOver");
        }

        if (remainingTime < 30)
        {
            timerText.color = Color.red;
        }


    int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void OnApplicationQuit()
    {
        if (prevScene == 2)
        {
            scoreLevel01 = remainingTime;
            Debug.Log("you have this score in lvl 1" + scoreLevel01);
        }
        else if (prevScene == 3)
        {
            scoreLevel02 = remainingTime;
            Debug.Log("you have this score in lvl 2" + scoreLevel02);
        }
        else if (prevScene == 4)
        {
            scoreLevel03 = remainingTime;
            Debug.Log("you have this score in lvl 3" + scoreLevel03);
        }
    }
}
