using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player_ito2 : MonoBehaviour
{
    public float speed = 5;
    public float hungry = 1;
    private AudioSource sound;
    Slider slider;
    [SerializeField]
    Animator mAnimator;
    public GameObject fish;
    bool chk_fish = false;

    // Use this for initialization
    void Start()
    {
        sound = GetComponent<AudioSource>();
        mAnimator = GetComponent<Animator>();
        // スライダーを取得する
        slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hungry > 0)
        {
            if (Input.GetKey("up"))
            {
                mAnimator.SetInteger("Direction", 1);
                hungry -= 0.001f;
            }
            else if (Input.GetKey("down"))
            {
                mAnimator.SetInteger("Direction", 2);
                hungry -= 0.001f;
            }
            else if (Input.GetKey("left"))
            {
                mAnimator.SetInteger("Direction", 3);
                hungry -= 0.001f;
            }
            else if (Input.GetKey("right"))
            {
                mAnimator.SetInteger("Direction", 4);
                hungry -= 0.001f;
            }
        }
        else
        {
            hungry = 0;
        }

        if (hungry <= 0.5 && chk_fish == false) {
          chk_fish = true;
          Debug.Log("hpyabai!!");
          Instantiate(fish,new Vector3(this.transform.position.x+Random.Range (1, 5),this.transform.position.x+Random.Range (1, 5),0),Quaternion.identity);
        }

        slider.value = hungry;
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed * hungry;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("fish"))
        {
            sound.PlayOneShot(sound.clip);
        }
    }

    void recovery_hungry()
    {
        hungry = 1;
    }
}
