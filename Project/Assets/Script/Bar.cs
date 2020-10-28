using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public Slider slider;
    //最大
    int maxHp = 100;
    //今
    int Hp;
    private PlayerHit playerHit;
    private int reward = 10;

    void Start()
    {
        playerHit = GameObject.Find("Player").GetComponent<PlayerHit>();

        //フル
        slider.value = 1;

        Hp = maxHp;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if ((collider.gameObject.tag == "Enemy") || (collider.gameObject.tag == "Eshot"))
        {

            Hp = Hp - playerHit.damage;

            slider.value = (float)playerHit.hp / (float)playerHit.hpMax;

        }

        //アイテム追加時
       /* if (collider.gameObject.tag == "HPItem")
        {
            playerHit.AddHP(reward);

            slider.value = (float)playerHit.hp / (float)playerHit.hpMax;
        }*/
    }
}