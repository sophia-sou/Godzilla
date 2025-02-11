using UnityEngine;

public class PatrolLevel03 : MonoBehaviour
{
    public GameObject LeftBarrier;
    public GameObject RightBarrier;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float tankSpeed;

    //public float left;
    //public float right;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = LeftBarrier.transform;
    }


    void Update()
    {
        //Vector2 point = currentPoint.position - transform.position;

        if (currentPoint == LeftBarrier.transform)
        {
            rb.linearVelocity = new Vector2(-tankSpeed, 0);
        }
        else
        {
            rb.linearVelocity = new Vector2(tankSpeed, 0);
        }

        if (transform.position.x <= -24 && currentPoint == LeftBarrier.transform)
        {
            flip();
            currentPoint = RightBarrier.transform;
        }
        if (transform.position.x >= 20 && currentPoint == RightBarrier.transform)
        {
            flip();
            currentPoint = LeftBarrier.transform;
        }
    }

    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

}
