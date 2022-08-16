using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Range(0, 10)] public float BulletSpeed = 3;
    public Transform BarrelLocator;
    public Rigidbody BulletPrefab;
    //public AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) == true)
        {
            Fire();
        }
    }

    public void Fire()
    {
        Rigidbody go = Instantiate(BulletPrefab, BarrelLocator.position, BarrelLocator.rotation);
        go.AddForce(BarrelLocator.forward * BulletSpeed, ForceMode.VelocityChange);
       // audio.Play();
    }
}
