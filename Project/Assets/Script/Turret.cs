using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret: MonoBehaviour
{
    public GameObject EShotPrefab;
    public float Speed;
    
    private int Timecount = 0;
    private bool Shotflag;

    void Start()
    {
        Shotflag = false;
    }

    void Update()
    {
        Timecount += 1;

        //発射間隔変更
        if (Timecount % 120 == 0)
        {
            if (Shotflag == true)
            {
                //生成
                GameObject eshot = Instantiate(EShotPrefab, transform.position, Quaternion.identity);
                Rigidbody eshotbr = eshot.GetComponent<Rigidbody>();
                //速度
                eshotbr.velocity = this.transform.forward * Speed;

                eshot.transform.forward = this.transform.forward;
                //弾削除
                Destroy(eshot, 4);
            }
            Shotflag = false;
        }
    }

    void OnTriggerStay(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            Shotflag = true;
        }
    }
}
