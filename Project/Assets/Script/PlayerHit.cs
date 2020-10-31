using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    public Slider slider;
    public Look script;
    public CameraCtr cameraCtr;
    //public GameObject effectPrefab;
    //public GameObject MainCamera;
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
         
            Destroy(coll.gameObject);
            //HPバー
            slider.value = (float)hp / (float)hpMax;

            if (slider.value == 0)
            {
                
                Destroy(gameObject);
                //スクリプト無効
                //gameObject.GetComponent<CameraCtr>().enabled = false;
                script.targetflag = false;
                Debug.Log("a");
                //エフェクト追加
                // GameObject effect = Instantiate(effectPrefab, transform.position, transform.rotation);
                //ゲームオーバー画面
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
