using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameMNG : MonoBehaviour
{
    public Text scoretext;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
            

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        scoretext.text = "Score: "+score.ToString("F2");
    }
}
