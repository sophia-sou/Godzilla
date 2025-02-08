using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level01"); // ма доуле ти ха йамеи яикооумт
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu"); //Go to main menu
    }
}
