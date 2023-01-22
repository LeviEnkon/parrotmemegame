using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using System.Timers;

public class EnemySpawnMNG : MonoBehaviour
{
    public GameObject Enemy;
    float t, tt, hard;
    // Start is called before the first frame update
    void Start()
    {
        hard = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        tt += Time.deltaTime;
        t += Time.deltaTime;
        if (t > (1 + UnityEngine.Random.Range(0.5f, hard)))
        {
            Instantiate(Enemy, new Vector3(20, 3, 0), Quaternion.identity);
            t = 0;
        }
        if (tt == 20 && hard >= 0.5f)
        {
            hard -= 0.1f;
            tt = 0;
        }
    }
}
