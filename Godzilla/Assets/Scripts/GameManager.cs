//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class GameManager : MonoBehaviour
//{
//    public static GameManager Instance; // Singleton pattern for easy access

//    private void
//    {
//        // Ensure there's only one GameManager instance
//        if (Instance == null)
//        {
//            Instance = this;
//            DontDestroyOnLoad(gameObject); // Persist across scenes
//        }
//        else
//        {
//            Destroy(gameObject);
//        }
//    }

//    public void LoadLevel(int levelIndex)
//    {
//        SceneManager.LoadScene(levelIndex); // Load level by index
//    }

//    public void LoadNextLevel()
//    {
//        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
//        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
//        {
//            SceneManager.LoadScene(nextSceneIndex);
//        }
//        else
//        {
//            Debug.Log("No more levels! Maybe load the Win scene?");
//        }
//    }

//    public void LoadWinScene()
//    {
//        SceneManager.LoadScene("WinScene"); // Ensure "WinScene" is added in Build Settings
//    }

//    public void LoadLoseScene()
//    {
//        SceneManager.LoadScene("LoseScene"); // Ensure "LoseScene" is added in Build Settings
//    }

//    public void RestartLevel()
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//    }

//    public void QuitGame()
//    {
//        Application.Quit();
//        Debug.Log("Game Quit!");
//    }
//}
