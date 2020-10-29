using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHIt : MonoBehaviour
{
    public GameObject Turret;
    public GameObject effect;
    public int TurretHP;
    //public AudioCilp deathSE;
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
            //Instantiate(effect,transform.position,transform.rotation);
            Destroy(coll.gameObject);
            //音
            /*var audioSource = FindObjectOfType<AudioSource>();
            audioSource.PlayOneShot(deathSE);*/

            if (TurretHP == 0)
            {
                Destroy(Turret);
            }
        }
    }
}
