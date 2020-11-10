using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPItem : MonoBehaviour
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
           
            Destroy(gameObject);
            //
            slider.value = (float)playerHit.hp / (float)playerHit.hpMax;
            Debug.Log("a" + playerHit.hpMax);
            Debug.Log("b" + playerHit.hp);
        }
    }
}
