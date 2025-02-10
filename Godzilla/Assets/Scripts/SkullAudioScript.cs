using UnityEngine;

public class SkullAudioScript : MonoBehaviour
{
    public AudioClip spawnSound;
    void Start()
    {
        AudioSource.PlayClipAtPoint(spawnSound, transform.position);
    }

}
