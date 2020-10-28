using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHit : MonoBehaviour
{ 
    private int hp;
    public int hpMax;
    public int damage;
    public Slider slider;

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

            Destroy(coll.gameObject);
            slider.value = (float)hp / (float)hpMax;
            if (hp == 0)
            {
                //  Destroy(this.gameObject);
                //ゲームオーバー画面
            }
        }
    }

}
