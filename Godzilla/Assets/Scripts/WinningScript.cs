using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningScript : MonoBehaviour
{
    private int totalEnemies;
    public static float winningScore;

    private void FixedUpdate()
    {
        totalEnemies = GameObject.FindGameObjectsWithTag("enemy").Length + GameObject.FindGameObjectsWithTag("helicopter").Length;

        if (totalEnemies <= 0)
        {
            Timer.remainTimeScore = GameObject.FindFirstObjectByType<Timer>().remainingTime;

            winningScore += Timer.remainTimeScore;

            SceneManager.LoadScene("WinningScene");
        }
    }

}
