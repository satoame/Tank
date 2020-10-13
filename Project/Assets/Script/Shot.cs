using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float shotSpeed;
    public GameObject ShotPrefab;
    //未定
    private AudioClip shotSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 砲弾のプレハブを実体化（インスタンス化）する。
            GameObject shot = Instantiate(ShotPrefab, transform.position, Quaternion.identity);

            Rigidbody shotRb = shot.GetComponent<Rigidbody>();

            // 力を加える
            shotRb.AddForce(transform.forward * shotSpeed);

            //３秒後破壊
            Destroy(shot, 3.0f);

            // 砲弾の発射音
           // AudioSource.PlayClipAtPoint(shotSound, transform.position);
        }
    }
}

