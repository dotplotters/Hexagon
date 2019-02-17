using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject obj;
    private float spawnRate = .4f;
    private float nexttime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nexttime)
        {
            Instantiate(obj);
            nexttime = Time.time + 1f / spawnRate;
        }
        

    }
}
