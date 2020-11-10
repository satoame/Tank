using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Item : MonoBehaviour
{
    public PlayerHit playerHit;
    public Slider slider;
    private int add;

    void Start()
    {
        slider.value = 1;
        add = 10;
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            //回復
            playerHit.hp = playerHit.hp + add;
           //Debug.Log("a"+playerHit.hp);
            Destroy(gameObject);
            //
            slider.value = (float)playerHit.hp / (float)playerHit.hpMax;
            Debug.Log("a" + playerHit.hpMax);
            Debug.Log("b" + playerHit.hp);
        }
    }
}
