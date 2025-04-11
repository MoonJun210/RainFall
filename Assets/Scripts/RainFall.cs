using UnityEngine;

public class RainFall : MonoBehaviour
{
    float size = 1.0f;
    int score = 1;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        float x = Random.Range(-2.4f, 2.4f);
        float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);

        int type = Random.Range(0, 4);

        switch(type)
        {
            case 0:
                size = 0.8f;
                score = 1;
                spriteRenderer.color = new Color(100 / 255f, 100 / 255f, 1f, 1f);
                break;
            case 1:
                size = 1.0f;
                score = 2;
                spriteRenderer.color = new Color(130 / 255f, 130 / 255f, 1f, 1f);
                break;
            case 2:
                size = 0.8f;
                score = -5;
                spriteRenderer.color = new Color(255 / 255f, 100 / 255f, 255 / 255f, 1f);
                break;
            default:
                size = 1.2f;
                score = 3;
                spriteRenderer.color = new Color(150 / 255f, 150 / 255f, 1f, 1f);
                break;
        }

        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.AddScore(score);
            Destroy(this.gameObject);
        }
    }
}
