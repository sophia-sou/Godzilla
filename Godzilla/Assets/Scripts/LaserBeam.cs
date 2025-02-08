using System.Threading;
using UnityEngine;

public class LaserBeam : MonoBehaviour
{

    public Transform LinePoint;
    
    public GameObject Line;
    private float timer;
    private void Start()
    {
        

    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
            { timer = 0;
            shoot();
                }

       
    }
    void shoot()
    { Instantiate(Line,LinePoint); }
}
