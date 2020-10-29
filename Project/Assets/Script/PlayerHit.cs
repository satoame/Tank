using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHit : MonoBehaviour
{
    public Slider slider;
    public int hpMax;
    private int hp;
    private int damage;

    void Start()
    {
        //フル
        slider.value = 1;
        hp = hpMax;
        damage = 10;
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Eshot")
        {

            hp = hp - damage;
            //エフェクト追加
            //Instantiate(,transform.position,transform.rotation);
            Destroy(coll.gameObject);
            //HPバー
            slider.value = (float)hp / (float)hpMax;
            if (hp == 0)
            {
                // Destroy(this.gameObject);
                //ゲームオーバー画面
            }
        }
    }

}
