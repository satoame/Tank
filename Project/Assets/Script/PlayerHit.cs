using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    public Slider slider;
    public Look script;
    public GameObject effectPrefab1;
    public GameObject effectPrefab2;
    public int hp;
    public int hpMax;
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
            Destroy(effect1, 1.0f);

            //敵のショット削除
            Destroy(coll.gameObject);

            //HPバー
            slider.value = (float)hp / (float)hpMax;

            //バー0の時
            if (slider.value == 0)
            {
                //Lookat無効
                script.targetflag = false;
              
                //エフェクト追加(破壊時)
                 GameObject effect2 = Instantiate(effectPrefab2, transform.position, transform.rotation);
                 Destroy(effect2, 1.0f);
                //ゲームオーバー画面
                //SceneManager.LoadScene("GameOver");
            }
        }
    }
}
