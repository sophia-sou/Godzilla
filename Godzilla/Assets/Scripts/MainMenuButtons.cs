using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    //PLAY button
    public void PlayGame()
    {
        SceneManager.LoadScene("Level01"); //only used to load level 01
    }
}
