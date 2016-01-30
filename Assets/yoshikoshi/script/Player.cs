using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public bool Back;
    public bool Front;
    public bool Left;
    public bool Right;
    [SerializeField]
    Animator mAnimator; //InspectorでAnimatorを指定

    // Use this for initialization
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            mAnimator.SetInteger("Direction", 1);         
        }
        else if (Input.GetKey("down"))
        {
            mAnimator.SetInteger("Direction", 2);
        }
        else if (Input.GetKey("left"))
        {
            mAnimator.SetInteger("Direction", 3);
        }
        else if (Input.GetKey("right"))
        {
            mAnimator.SetInteger("Direction", 4);
        }

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
