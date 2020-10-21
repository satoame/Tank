using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHIt : MonoBehaviour
{
    public GameObject Turret;
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
            Destroy(coll.gameObject);

            if (TurretHP == 0)
            {
                Destroy(Turret);
            }
        }
    }
}
