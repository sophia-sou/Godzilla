using Unity.Hierarchy;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using static UnityEditor.Experimental.GraphView.GraphView;
using Unity.VisualScripting;

public class FireBallMovement : MonoBehaviour
{
  
    public float fireSpeed = 20f;
    public Rigidbody2D rb;
    public string Godzilla = "Godzilla";

    void Start()
    {
       GameObject Godzilla = GameObject.Find("Godzilla");
       gameObject.layer=Godzilla.layer;

        float xInput = Input.GetAxisRaw("Horizontal");
        Vector3 localScale = transform.localScale;
       
        if (xInput == 1)
        { 
            rb.linearVelocity = transform.right * fireSpeed;
        }
        else if (xInput == -1)
        { 
            rb.linearVelocity = -transform.right * fireSpeed;

            localScale.x = Mathf.Abs(localScale.x) * Mathf.Sign(xInput);
            transform.localScale = localScale;
        }
        else if (xInput == 0 && Godzilla.transform.localScale.x == 1)
        {
            rb.linearVelocity = transform.right * fireSpeed;
        }
        else if (xInput == 0 && Godzilla.transform.localScale.x == -1)
        {
            rb.linearVelocity = -transform.right * fireSpeed;
           
            localScale.x = Mathf.Abs(localScale.x) * -1;
            transform.localScale = localScale;
        }
      
        
    }

    


}

