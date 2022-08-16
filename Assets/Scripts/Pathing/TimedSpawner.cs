using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    public GameObject enemy;
    public float timer = 10;
    public GameObject spawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= 0)
        {
            Instantiate(enemy, spawnLocation.transform);
            timer = 10;
        }
        timer -= Time.deltaTime;
    }
}
