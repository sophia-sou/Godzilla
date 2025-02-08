using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class TankDeath : MonoBehaviour
{
    public GameObject laserPrefab;
    private Vector2 lastPosition;
    public GameObject Godzilla;
    private bool canDestroy;
    

    private void Start()
    {
        canDestroy = false;
    }

    private void FixedUpdate()
    {
        if (canDestroy == true && Input.GetButtonDown("Fire2"))
        {
            Vector3 tankPosition = transform.position;

            GameObject laser = Instantiate(laserPrefab, tankPosition, Quaternion.identity);

            Destroy(gameObject);

            Destroy(laser, 1f);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.collider.name.Contains(Godzilla.name))
        {
            canDestroy = true;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.name.Contains(Godzilla.name))
        {
            canDestroy = false;
        }
    }
}