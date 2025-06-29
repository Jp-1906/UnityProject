using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float kekuatanLompat;
    float score;
    public GameObject gameOver;
    
    public AudioSource audio;
    public AudioClip jumpClip;
    public AudioClip scoreClip;
    public AudioClip obstacleClip;

    public Text gameoverScoreTxt;
    public Text scoreTxt;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        scoreTxt.text = "" + score;

        if(Input.GetMouseButtonDown(0))
        {
            audio.clip = jumpClip;
            audio.Play();
            
            Rb.velocity = Vector2.up*kekuatanLompat;
        } 
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "obstacle")
        {
            gameoverScoreTxt.text = "" + score;
            gameOver.SetActive(true);

            audio.clip = obstacleClip;
            audio.Play();

            Time.timeScale = 0f;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="point")
        {
            audio.clip = scoreClip;
            audio.Play();
            score++;
        }
    }
    
    public void Retry()
    {
        Application.LoadLevel(1);

        Time.timeScale = 1f;
    }
}


