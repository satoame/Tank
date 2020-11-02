using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    public Slider slider;
    public Look script;
    //public CameraCtr cameraCtr;
    public GameObject effectPrefab1;
    public GameObject effectPrefab2;
    private int hp;
    private int hpMax;
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
            //エフェクト追加(ダメージ時)
            GameObject effect1 = Instantiate(effectPrefab1, transform.position, transform.rotation);
            Destroy(coll.gameObject);
            //HPバー
            slider.value = (float)hp / (float)hpMax;

            if (slider.value == 0)
            {
                //プレイヤー削除(削除にカメラ不明)
                //Destroy(gameObject);

                //Lookat無効
                script.targetflag = false;
              
                //エフェクト追加(破壊時)
                 GameObject effect2 = Instantiate(effectPrefab2, transform.position, transform.rotation);
                 Destroy(effect2, 2.0f);
                //ゲームオーバー画面
                //SceneManager.LoadScene("GameOver");
            }
        }
    }
}
