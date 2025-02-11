using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using System;

using System.Linq;
using System.IO;


public class GodzillaHealth : MonoBehaviour
{
    public static int previousSceneIndex;

    Rigidbody2D rb;
    public GameObject tankLaser;
    public GameObject kingAmmo;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public GameObject skullPrefab;



    // starting health value
    public int health = 100;

    //scene save
    private string filePath;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // decrease health if collision with bullet (Laser To Be) 
        if (other.collider.name.Contains(tankLaser.name))
            {
            health -= 5;
            Destroy(other.gameObject);
            DestroyHeart();

            //die if no health
            if (health <= 0)
            {
                health = 0;
                DestroyHeart();
                godzillaDead();
                SceneManager.LoadScene("GameOver");
            }
        }
        // decrease health if collision with bullet (Laser To Be) 
        else if (other.collider.name.Contains(kingAmmo.name))
        {
            health -= 10;
            Destroy(other.gameObject);
            DestroyHeart();

            //die if no health
            if (health <= 0)
            {
                health = 0;
                DestroyHeart();
                godzillaDead();
                SceneManager.LoadScene("GameOver");
            }
        }

        // die if collision with helicopter
        if (other.gameObject.CompareTag("helicopter"))
        {
            health = 0;
            DestroyHeart();
           

            godzillaDead();
            SceneManager.LoadScene("GameOver");
        }

        if (other.gameObject.CompareTag("spikebarrier"))
        {
            health = 0;
            DestroyHeart();
           

            godzillaDead();
            SceneManager.LoadScene("GameOver");
        }
    }

    private void godzillaDead()
    {
            //instantiate skull before dead
            Vector3 godzillaPosition = transform.position;

            GameObject skull = Instantiate(skullPrefab, godzillaPosition, Quaternion.identity);
            Destroy(gameObject);

            Destroy(skull, 2f);
    }

    private void OnApplicationQuit()
    {
        filePath = Path.Combine(Application.persistentDataPath, "savedNumber.txt");
        SaveNumber(SceneManager.GetActiveScene().buildIndex);
    }

    void SaveNumber(int number)
    {
        File.WriteAllText(filePath, number.ToString());
        Debug.Log("Number saved: " + number);
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
