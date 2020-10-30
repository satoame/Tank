using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    private GameObject traget;

    void Start()
    {
        traget = GameObject.Find("Player");
    }

    void Update()
    {
       this.gameObject.transform.LookAt(traget.transform.position);
    }
}
