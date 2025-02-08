using UnityEngine;

public class GodzillaAnimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Play Attack animation when the Space key is pressed
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("Attack");
        }

        // Play Kick animation when the Right Mouse Button is clicked
        if (Input.GetButtonDown("Fire2"))
        {
            animator.SetTrigger("Kick");
        }
    }
}
