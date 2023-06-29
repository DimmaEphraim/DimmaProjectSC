using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipaSpawner : MonoBehaviour
{
    float time = 0;
    float timer = 2;
    public GameObject Pipa;

    void Update()
    {
        if(time<=0)
        {
            Instantiate(Pipa, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
