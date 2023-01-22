using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SocialPlatforms;

public class PlayerMNG : MonoBehaviour
{
    public AudioClip jumpsound;
    AudioSource audioSource;
    //public Image hpimage;
    //float maxHP = 5;
    //float currentHP = 5;

    public float speed = 5.0f;
    public float jump = 200.0f;
    int jumpCount;
    Animator animator;

    public float score;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        audioSource = this.gameObject.GetComponent<AudioSource>();
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        if (Input.GetKeyDown("space") == true && jumpCount < 2)
        {
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, jump, 0);
            animator.SetBool("jump", true);
            jumpCount += 1;
            audioSource.clip = jumpsound;
            audioSource.Play();
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            jumpCount = 0;
            animator.SetBool("jump", false);
        }
        if (col.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetFloat ("FinalScore", score);
            SceneManager.LoadScene("GameOver");
        }
    }
 }