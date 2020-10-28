using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{ 
    public int hp;
    public int hpMax;
    public int damage;

    void Start()
    {
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Eshot")
        {

            hp = hp - damage;
            //エフェクト追加

            Destroy(coll.gameObject);

            if (hp == 0)
            {
              //  Destroy(this.gameObject);
                //ゲームオーバー画面
            }
        }
    }

}
