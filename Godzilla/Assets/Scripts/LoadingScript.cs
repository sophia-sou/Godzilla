using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour
{
    private float delayTime;
    private float remainTime;

    private void Start()
    {
        delayTime = 2;

        remainTime = delayTime;
    }

    private void Update()
    {
        remainTime -= Time.deltaTime;

        if (remainTime <= 0 )
        {
            SceneManager.LoadScene("StartMenu");
        }
    }
}
