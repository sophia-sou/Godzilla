using UnityEngine;

public class TankShoot : MonoBehaviour
{
    private float timeBetweenShots;
    private float startShotTime = 5;
    public GameObject tankLaser;


    void Start()
    {
        timeBetweenShots = startShotTime;
    }

    void Update()
    {
        if(timeBetweenShots <= 0)
        {
            //instantiate at enemy's (tank) current position
            //no roatation
            GameObject newChild = Instantiate(tankLaser, transform.position, Quaternion.identity);
           
            tankLaser.layer = gameObject.layer;

            timeBetweenShots = startShotTime;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime; //each frame we get closer to shoot time
        }
    }
}
