using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    float time = 0;
    float timer = 1;
    public GameObject obstacle;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(time<=0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
