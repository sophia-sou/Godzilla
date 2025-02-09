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

            //store current scene index
            int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("LastPlayedLevel", currentLevelIndex);
            PlayerPrefs.Save();

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

}
