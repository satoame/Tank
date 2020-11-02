using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    private GameObject traget;
    public bool targetflag;

    void Start()
    {
        traget = GameObject.Find("Player");
        targetflag = true;
    }

    void Update()
    {
        //存在する時
        if (targetflag == true)
        {
            this.gameObject.transform.LookAt(traget.transform.position);
        }
        else if(targetflag == false)
        {
            this.gameObject.transform.LookAt(null);
        }
    }
}
