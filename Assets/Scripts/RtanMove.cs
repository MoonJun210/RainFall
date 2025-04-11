using UnityEngine;

public class RtanMove : MonoBehaviour
{
    float direction = 0.05f;
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
            direction *= -1;
        }

        if(transform.position.x > 2.6f)
        {
            spriteRenderer.flipX = true;
            direction = -0.05f;
        }
        
        if(transform.position.x < -2.6f)
        {
            spriteRenderer.flipX = false;
            direction = 0.05f;
        }

        transform.position += Vector3.right * direction;

    }
}
