using UnityEngine;



public class HelicopterDestraction : MonoBehaviour
{
    public GameObject fireball;
    public GameObject laserPrefab;

    Rigidbody2D rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.name.Contains(fireball.name))
        {
            Vector3 helicopterPosition = transform.position;

            GameObject laser = Instantiate(laserPrefab, helicopterPosition, Quaternion.identity);

            Destroy(gameObject);

            Destroy(collision.gameObject);

            Destroy(laser, 1f);
        }
    }


}