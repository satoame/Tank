using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyattack : MonoBehaviour
{
    private Animation anim;
  
    void Start()
    {
        //アニメーション
        anim = this.gameObject.GetComponent<Animation>();
    }

    void Update()
    {
       
    }

    void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("a");
            //攻撃アニメーション追加
            anim.Play("attack1");
        }
    }
}
