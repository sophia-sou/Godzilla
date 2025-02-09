using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GodzillaHealth : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject tankLaser;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public GameObject skullPrefab;

    // starting health value
    public int health = 100;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected with: " /* + other.gameObject.name*/);

        // decrease health if collision with bullet (Laser To Be) 
        if (other.collider.name.Contains(tankLaser.name))
            {
            health -= 5;
            Destroy(other.gameObject);

            Debug.Log("Godzilla hit by bullet! Health: " + health);

            DestroyHeart();

            if (health <= 0)
            {
                health = 0;
                DestroyHeart();

                godzillaDead();
                SceneManager.LoadScene("GameOver");
            }
        }
        // die if collision with other
        
        if (other.gameObject.CompareTag("helicopter"))
        {
            health = 0;
            DestroyHeart();

            godzillaDead();
            SceneManager.LoadScene("GameOver");
            Debug.Log("Godzilla hit by tank or helicopter! Health: " + health);
        }
    }

    private void godzillaDead()
    {

        //instantiate skull before dead
        Vector3 godzillaPosition = transform.position;

        GameObject skull = Instantiate(skullPrefab, godzillaPosition, Quaternion.identity);

        Destroy(gameObject);

        Destroy(skull, 2f);

        //store current level index
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("LastPlayedLevel", currentLevelIndex);
        PlayerPrefs.Save();
    }

    private void DestroyHeart()
    {
        if (health < 80 && health >= 60)
        {
            Destroy(heart5);
        }
        if (health < 60 && health >= 40)
        {
            Destroy(heart4);
        }
        if (health < 40 && health >= 20)
        {
            Destroy(heart3);
        }
        if (health < 20 && health >= 0)
        {
            Destroy(heart2);
        }
        if (health == 0)
        {
            Destroy(heart1);
        }
    }

}
