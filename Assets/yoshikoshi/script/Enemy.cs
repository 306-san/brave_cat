using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    Animator animator;
    GameObject player;
    float EnemySpeed = 0.025f;
    void Start()
    {

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
        if (ex < px)
        {
            transform.Translate(transform.right * EnemySpeed);
        }
        else {
            transform.Translate(transform.right * -EnemySpeed);
        }

        if (ey < py)
        {
            transform.Translate(transform.up * EnemySpeed);
        }
        else {
            transform.Translate(transform.up * -EnemySpeed);
        }
    }
}
