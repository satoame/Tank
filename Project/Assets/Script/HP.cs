using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public PlayerHit playerHit;

    public int hp;
    public int damege;

    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        damege = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
