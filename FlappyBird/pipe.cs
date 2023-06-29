using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipaScript : MonoBehaviour
{
    float N_Random;
    void Start()
    {
        N_Random = Random.Range(-3.65f, -9.25f);
        transform.position = new Vector2(transform.position.x, N_Random);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100, Time.deltaTime * 5);
    }
}
