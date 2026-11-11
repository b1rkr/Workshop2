using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private SpriteRenderer weapon;

    private float velocityX;
    private float velocityY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocityX = rb.linearVelocity.x;
        velocityY = rb.linearVelocity.y;
        
        anim.SetFloat("VelocityX", velocityX);
        anim.SetFloat("VelocityY", velocityY);

        if (velocityX <= -0.1f)
        {
            sr.flipX = true;
        }
        else if (velocityX >= 0.1f)
        {
            sr.flipX = false;
        }
        
        if (velocityX <= -0.1f)
        {
            weapon.flipX = true;
        }
        else if (velocityX >= 0.1f)
        {
            weapon.flipX = false;
        }
    }
}
