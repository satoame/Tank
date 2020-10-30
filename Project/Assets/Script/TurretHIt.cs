using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHIt : MonoBehaviour
{
    public GameObject Turret;
    public GameObject effectPrefab;
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
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(coll.gameObject);
            //Destroy(effect, 2.0f);
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
