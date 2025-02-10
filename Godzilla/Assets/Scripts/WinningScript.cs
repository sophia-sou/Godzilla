using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningScript : MonoBehaviour
{
    private int totalEnemies;

    private void FixedUpdate()
    {
        totalEnemies = GameObject.FindGameObjectsWithTag("enemy").Length + GameObject.FindGameObjectsWithTag("helicopter").Length;

        if (totalEnemies <= 0)
        {
            SceneManager.LoadScene("WinningScene");
        }
    }
}


//int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
//PlayerPrefs.SetInt("LastPlayedLevel", currentLevelIndex);
//PlayerPrefs.Save();
