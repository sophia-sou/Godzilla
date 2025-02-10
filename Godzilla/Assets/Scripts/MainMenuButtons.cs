using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level01"); //only used to load level 01
    }
    public void ChooseLevel()
    {
        SceneManager.LoadScene("ChooseLevelScene");
    }
}
