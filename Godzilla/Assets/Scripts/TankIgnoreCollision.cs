using UnityEngine;


public class TankIgnoreCollision : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy")) //tank = tag enemy //helicopter = tag helicopter
        {
            Physics2D.IgnoreCollision(other.collider, GetComponent<Collider2D>());

        }
    }
}
