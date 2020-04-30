using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    float bullet_speed = 1600;
    float bullet_timer;
    float bullet_wait = 1;
    public GameObject bullet;

    // Update is called once per frame
    void Update(){
        bullet_timer += Time.deltaTime;
        if (bullet_timer < bullet_wait){
            return;
        }

        if (Input.GetKey (KeyCode.Space)) {
            bullet_timer = 0;
            GameObject bul = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            Rigidbody rbbul = bul.GetComponent<Rigidbody>();
            rbbul.AddForce(rbbul.transform.forward * bullet_speed);
            Destroy(bul, 1.0f);

            GetComponent<AudioSource>().Play();
        }
    }
}
