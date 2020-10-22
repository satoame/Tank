using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    //public GameObject Player;
    public int PlayerHP;

    private int damege;

    void Start()
    {
        damege = 10;
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Eshot")
        {

            PlayerHP = PlayerHP - damege;
            //エフェクト追加

            Destroy(coll.gameObject);

            if (PlayerHP == 0)
            {
              //  Destroy(this.gameObject);
                //ゲームオーバー画面
            }
        }
    }

}
