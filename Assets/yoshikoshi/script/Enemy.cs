using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    Animator mAnimator;
    GameObject player;
    float EnemySpeed = 0.075f;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        player = GameObject.Find("Player");
        //17行目(Updateの中)に下記を追加
        float px, py, ex, ey;

        px = player.transform.localPosition.x;
        py = player.transform.localPosition.y;
        ex = transform.localPosition.x;
        ey = transform.localPosition.y;

        //playerの座標と自分の座標を比較して、より近づくように動く

        if (ey < py)
        {
            transform.Translate(transform.up * EnemySpeed);
            mAnimator.SetInteger("Direction", 1);
        }
        else if (ey == py && ex < px) {
            mAnimator.SetInteger("Direction", 4);
        }
        else if (ey == py && ex > px) {
            mAnimator.SetInteger("Direction", 3);
        }
        else {
            transform.Translate(transform.up * -EnemySpeed);
            mAnimator.SetInteger("Direction", 2);
        }

        if (ex < px)
        {
            transform.Translate(transform.right * EnemySpeed);
            mAnimator.SetInteger("Direction", 4);
        }
        else if (ex == px && ey < py)
        {
            mAnimator.SetInteger("Direction", 1);
        }
        else if (ex == px && ey > py)
        {
            mAnimator.SetInteger("Direction", 2);
        }
        else {
            transform.Translate(transform.right * -EnemySpeed);
            mAnimator.SetInteger("Direction", 3);
        }
    }
}
