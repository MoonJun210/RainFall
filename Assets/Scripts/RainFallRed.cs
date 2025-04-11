using UnityEngine;

public class RainFallRed : MonoBehaviour
{
    float size = 1.0f;
    int score = 5;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        float x = Random.Range(-2.4f, 2.4f);
        float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);

        size = 0.8f;
        //spriteRenderer.color = new Color(255 / 255f, 100 / 255f, 255 / 255f , 1f);

        transform.localScale = new Vector3(size, size, 0);
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.RemoveScore(score);
            Destroy(this.gameObject);
        }
    }
}
