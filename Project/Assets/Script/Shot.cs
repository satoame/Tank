using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //public Player player;
    public float shotSpeed;
    //時間(総秒数の分割数)
    //public float time;
    //力(初速度)
    /*public*/
    Vector3 force = Vector3.zero;
    //質量(Kg)
    private float mass;
   // 重力
    private Vector3 gravity;
   

    void Start()
    {
        //gravity = Physics.gravity;
        //mass = GetComponent<Rigidbody>().mass;
    }

    void Update()
    {
        //ショット
        Rigidbody shotbr = this.GetComponent<Rigidbody>();
        //速度
        shotbr.velocity = this.transform.forward * shotSpeed;
        //方向
        transform.forward = this.transform.forward;
        //音
        //AudioSource.PlayClipAtPoint(shotSound, transform.position);
        //Vector3 force = this.transform.forward * shotSpeed;
        //Debug.Log("force" + force);
        //Destroy(shot, 4);
        //this.transform.position = CalcPositionFromForce(transform.position);
    }

    //弾道 Vector3 CalcPositionFromForce(初期位置)
   /* Vector3 CalcPositionFromForce(Vector3 startPosition)     
    {
        Vector3 speed = (force / mass) * Time.fixedDeltaTime;
        Debug.Log("speed" + speed);
        Vector3 position = (speed * time) + (gravity * 0.5f * Mathf.Pow(time, 2));
        Debug.Log("startposition" + startPosition);
        Debug.Log("possition"+position);
        Vector3 nextPosition = startPosition + position;
        Debug.Log("next"+ nextPosition);
        return nextPosition;
    }*/
}
