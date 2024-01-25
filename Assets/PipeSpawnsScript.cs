using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnsScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffSet = 8;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else {
            spawnPipe();
            timer = 0;
        }
         
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float heighesttPoint = transform.position.y + heightOffSet;
        Instantiate(pipe, new Vector3 (transform.position.x, Random.Range(lowestPoint, heighesttPoint), 0), transform.rotation);
    }
}

