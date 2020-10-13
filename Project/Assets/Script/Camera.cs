using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject targetObj;
    private Vector3 targetPos;

    void Start()
    {
        targetObj = GameObject.Find("Tank Prefab");
        targetPos = targetObj.transform.position;
    }

    void Update()
    {
        
        //transform.position += targetObj.transform.position - targetPos;
        //targetPos = targetObj.transform.position;
    }
}