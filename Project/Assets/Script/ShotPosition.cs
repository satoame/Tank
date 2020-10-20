using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPosition : MonoBehaviour
{
    public GameObject ShotPrefab;
    public float shotSpeed;

    void Start()
    {
    }

    void Update()
    {
        //ショット
        if (Input.GetMouseButtonDown(0))
        {
            //生成
            GameObject shot = Instantiate(ShotPrefab, transform.position, Quaternion.identity);
            Rigidbody shotbr = shot.GetComponent<Rigidbody>();
            //速度
            shotbr.velocity = this.transform.forward * shotSpeed;

            shot.transform.forward = this.transform.forward;
        }
    }
}
