using UnityEngine;
using System.Collections;

public class Player_ito : MonoBehaviour
{
SpriteRenderer MainSpriteRenderer;
public Sprite BackSprite;
public Sprite FrontSprite;
public Sprite LeftSprite;
public Sprite RightSprite;
public float speed = 5;
public float hungry = 1;
// Use this for initialization
void Start()
{
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
}

// Update is called once per frame
void Update()
{
        if (hungry > 0) {
                if (Input.GetKey("up"))
                {
                        hungry -= 0.0005f;
                        ChangeStateToBack();
                }
                else if (Input.GetKey("down"))
                {
                        hungry -= 0.0005f;
                        ChangeStateToFront();
                }
                else if (Input.GetKey("left"))
                {
                        hungry -= 0.0005f;
                        ChangeStateToLeft();
                }
                else if (Input.GetKey("right"))
                {
                        hungry -= 0.0005f;
                        ChangeStateToRight();
                }
        } else {
                hungry = 0;
        }
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed * hungry;
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
void recovery_hungry(){
        hungry = 1;
}
}
