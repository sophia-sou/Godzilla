using UnityEngine;
using TMPro;

public class EnemiesLeftScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI enemiesText;
    private int enemiesStart;
    private int enemiesLeft;

    private void Start()
    {
        enemiesStart = GameObject.FindGameObjectsWithTag("enemy").Length + GameObject.FindGameObjectsWithTag("helicopter").Length;
        enemiesLeft = enemiesStart;
        UpdateEnemyText();
    }
    private void FixedUpdate()
    {
        enemiesLeft = GameObject.FindGameObjectsWithTag("enemy").Length + GameObject.FindGameObjectsWithTag("helicopter").Length;
        UpdateEnemyText();
    }

    private void UpdateEnemyText()
    {
        enemiesText.text = "Enemies killed:" + (enemiesStart - enemiesLeft) + "/" + enemiesStart;
    }
}
