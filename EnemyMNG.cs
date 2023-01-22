using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMNG : MonoBehaviour
{
    public float speed = 10;
    private float disappear = -8;
    private float respawn = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        if (this.gameObject.transform.position.x < disappear)
        {
            Destroy(this.gameObject);
        }
    }
}
