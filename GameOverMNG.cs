using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMNG : MonoBehaviour
{
    public AudioClip gumisound;
    AudioSource audioSource;
    public Text ScoreText;
    float Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = PlayerPrefs.GetFloat("FinalScore");
        ScoreText.text = "Your Score: " + Score.ToString("F2");
        audioSource = this.gameObject.GetComponent<AudioSource>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") == true)
        {
            SceneManager.LoadScene("Start");
        }
    }
}
