using UnityEngine;
using UnityEngine.SceneManagement;

public class KingHealth : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject fireBall;
    private float health = 15;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // decrease health if collision with fire
        if (other.collider.name.Contains(fireBall.name))
        {
            Destroy(other.gameObject);
            health -= 1;


            //die if no health
            if (health <= 0)
            {
                health = 0;
                Destroy(gameObject);
            }
        }
    }
}
