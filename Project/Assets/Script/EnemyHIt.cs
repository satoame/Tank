using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyHIt : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject EnemyPositon;
    public GameObject Positon;
    public GameObject effectEnemy;
    public GameObject effectEnemy1;
    public GameObject[] item;
    private int hp;
    private int damage;

    void Start()
    {
        hp = 20;
        damage = 10;
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag == "Shot")
        {
            //HP
            hp = hp - damage;

            //エフェクト追加
            GameObject effect = Instantiate(effectEnemy, EnemyPositon.transform.position, Quaternion.identity);
            //削除
            Destroy(coll.gameObject);

            //HP0
            if(hp == 0)
            {
                //エフェクト追加
                GameObject effect1 = Instantiate(effectEnemy1, Positon.transform.position, Quaternion.identity);
                Destroy(Enemy);
                //アイテム追加
                //Vector3 = transform.position;
                int ItemNunber = Random.Range(0, item.Length);

                if (item.Length != 0)
                {
                    Instantiate(item[ItemNunber], EnemyPositon.transform.position, Quaternion.identity);
                }
            }
        }

    }
}
