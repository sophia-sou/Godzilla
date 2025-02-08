using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level01"); // �� ����� �� �� ����� ��������
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu"); //Go to main menu
    }
}
