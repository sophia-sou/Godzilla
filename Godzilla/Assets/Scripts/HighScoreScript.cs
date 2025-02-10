using UnityEngine;

[System.Serializable]
public class HighScoreScript : MonoBehaviour
{
    private int prevScene = GodzillaHealth.previousSceneIndex;
    private float scoreLevel01 = Timer.scoreLevel01;
    private float scoreLevel02 = Timer.scoreLevel02;
    private float scoreLevel03 = Timer.scoreLevel03;
    public float score;
    
    private void Start()
    {
        if (prevScene == 4)
        {
            score = scoreLevel01 + scoreLevel01 + scoreLevel03;
            Debug.Log("score"+ score);
        }
        else
        {
            Debug.Log("oups");
            return;
        }
    }
}
