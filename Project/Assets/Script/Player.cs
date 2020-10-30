using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public GameObject ShotPrefab;
    public GameObject ShotPosition;
   

    private Rigidbody rb;

    private float movementValue;
    private float turnValue;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //ショット
        if (Input.GetMouseButtonDown(0))
        {
            GameObject shot = Instantiate(ShotPrefab, ShotPosition.transform.position, ShotPosition.transform.rotation);
        }

        Move();
        Turn();
    }

    // 前進&後退
    void Move()
    {
        movementValue = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * movementValue * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    // 旋回
    void Turn()
    {
        turnValue = Input.GetAxis("Horizontal");
        float turn = turnValue * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0, turn, 0);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}

