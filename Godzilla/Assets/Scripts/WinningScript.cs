using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningScript : MonoBehaviour
{private int killCount = GameOver.killCount;
    private int totalEnemies;
    private float sceneIndex = GodzillaHealth.previousSceneIndex;
    public static float winningScore;

    private void FixedUpdate()
    {
        totalEnemies = GameObject.FindGameObjectsWithTag("enemy").Length + GameObject.FindGameObjectsWithTag("helicopter").Length;

        if (totalEnemies <= 0)
        {
            Timer.remainTimeScore = GameObject.FindFirstObjectByType<Timer>().remainingTime;

            winningScore += Timer.remainTimeScore;

            SceneManager.LoadScene("WinningScene");

            if (sceneIndex == 4)//|| killCount==0&& sceneIndex==3)
            {
                HighScores.SetPendingScore(winningScore);
                SceneManager.LoadScene("HighScores");
            }
        }
    }

}
