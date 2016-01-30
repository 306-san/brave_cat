using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    public Sprite BackSprite;
    public Sprite FrontSprite;
    public Sprite LeftSprite;
    public Sprite RightSprite;
    public float speed = 5;
    // Use this for initialization
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            ChangeStateToBack();
        }
        else if (Input.GetKey("down"))
        {
            ChangeStateToFront();
        }
        else if (Input.GetKey("left"))
        {
            ChangeStateToLeft();
        }
        else if (Input.GetKey("right"))
        {
            ChangeStateToRight();
        }

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    void ChangeStateToBack()
    {
        MainSpriteRenderer.sprite = BackSprite;
    }

    void ChangeStateToFront()
    {
        MainSpriteRenderer.sprite = FrontSprite;
    }

    void ChangeStateToLeft()
    {
        MainSpriteRenderer.sprite = LeftSprite;
    }

    void ChangeStateToRight()
    {
        MainSpriteRenderer.sprite = RightSprite;
    }
}
