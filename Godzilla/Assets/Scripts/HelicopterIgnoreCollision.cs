using UnityEngine;

public class HelicopterIgnoreCollision : MonoBehaviour
{
   
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("helicopter")) 
        {
            Physics2D.IgnoreCollision(other.collider, GetComponent<Collider2D>());
        }
    }
}
