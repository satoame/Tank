using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHIt : MonoBehaviour
{
    public GameObject Turret;
    public GameObject effectPrefab;
    public GameObject effectPrefab1;
    public int TurretHP;
    private int damege;

    void Start()
    {
        damege = 10;
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Shot")
        {
            //ダメージ
            TurretHP = TurretHP - damege;

            //エフェクト追加
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            //shot削除
            Destroy(coll.gameObject);

            //エフェクト削除
            Destroy(effect, 0.5f);

            if (TurretHP == 0)
            {
                Destroy(Turret);

                //削除時のエフェクト
                GameObject effect2 = Instantiate(effectPrefab1, transform.position, Quaternion.identity);
                Destroy(effect2, 1.0f);
            }
        }
    }
}
