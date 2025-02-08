using UnityEngine;

public class LaserShoot : MonoBehaviour
{
    public float laserSpeed;

    private Transform playerPosition;
    private Vector2 targetPosition;

    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        targetPosition = new Vector2(playerPosition.position.x, playerPosition.position.y); 
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, laserSpeed * Time.deltaTime);

        if (transform.position.x == targetPosition.x && transform.position.y == targetPosition.y)
        {
            DestroyLaser();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            DestroyLaser();
        }
    }
    void DestroyLaser()
    {
        Destroy(gameObject);
    }
}
