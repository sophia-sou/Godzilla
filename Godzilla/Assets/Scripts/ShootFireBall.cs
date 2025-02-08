using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFireBall : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireballPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

       
    }

    void Shoot()
    { //makes the fireball child of godzilla
        GameObject newChild =Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
        Destroy(newChild, 1f);    
    }
}