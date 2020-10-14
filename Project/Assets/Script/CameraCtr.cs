using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtr : MonoBehaviour

{   //メインカメラ
    public GameObject mainCamera;
    //サブカメラ
    public GameObject subCamera;

    private bool mainCameraIN = true;

    void Start()
    {
        subCamera.SetActive(false);
    }

    //メインカメラ
    public void MainCamera()
    {
        mainCamera.SetActive(true);
        subCamera.SetActive(false);

        mainCameraIN = true;
    }

    //サブカメラ
    public void SubCamera()
    {
        mainCamera.SetActive(false);
        subCamera.SetActive(true);

        mainCameraIN = false;
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
