using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollision : MonoBehaviour
{
    public GameObject Godzilla;
    public GameObject skullPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name.Contains(Godzilla.name))
        {
            //instantiate skull before dead
            Vector3 godzillaPosition = transform.position;

            GameObject skull = Instantiate(skullPrefab, godzillaPosition, Quaternion.identity);

            Destroy(Godzilla);
            Destroy(skull, 2f);

            SceneManager.LoadScene("GameOver");
        }
    }
}
