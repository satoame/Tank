using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Versioning;
using UnityEngine;

public class CameraCtr : MonoBehaviour

{   //メインカメラ
    public GameObject mainCamera;
    //サブカメラ
    public GameObject subCamera;
    //画像
    public GameObject Image;
    public GameObject Panel1;
    public GameObject Panel2;
    public bool sliderflag;
    private bool mainCameraIN = true;

    void Start()
    {
        subCamera.SetActive(false);
        Image.SetActive(false);
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        sliderflag = true;
    }

    //メインカメラ
    public void MainCamera()
    {
        mainCamera.SetActive(true);
        subCamera.SetActive(false);
        Image.SetActive(false);
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        mainCameraIN = true;
        //slider オン
        sliderflag = true;
    }

    //サブカメラ
    public void SubCamera()
    {
        mainCamera.SetActive(false);
        subCamera.SetActive(true);
        Image.SetActive(true);
        Panel1.SetActive(true);
        Panel2.SetActive(true);
        mainCameraIN = false;
        //slidre オフ
        sliderflag = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && mainCameraIN == true)
        {
            SubCamera();
        }
        else if(Input.GetKeyDown(KeyCode.F) && mainCameraIN == false)
        {
            MainCamera();
        }
    }
    
}
