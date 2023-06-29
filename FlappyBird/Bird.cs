using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float jumpForce;
    float score;
    float highscore;

    float PureScore;
    float CheatScore;
    float fail;

    public bool PlayerInvicible;

    public GameObject GameOver;
    public GameObject Scoremain;
    public GameObject Highscoremain;

    public Text scoreTxt;
    public Text highscoreTxt;
    public Text scoreTxt_d;
    public Text highscoreTxt_d;
    public Text CheatTxt;

    public AudioSource Score;
    public AudioSource Flap;
    public AudioSource Hit_Sound;
    public AudioSource PipaSound;
    public AudioSource groundSound;

    void Start()
    {
        Rb = GetComponent<‎Rigidbody2D>();
        Physics.gravity = new Vector3(0, -25.0F, 0);

        Vector3 newRotationflap = new Vector3(0, 0, -20);
        transform.eulerAngles = newRotationflap;

        highscore = PlayerPrefs.GetFloat("HighScore");
        fail = PlayerPrefs.GetFloat("Fail");

        PureScore = PlayerPrefs.GetFloat("PureScore");
        CheatScore = PlayerPrefs.GetFloat("CheatScore");

        CheatTxt.color = Color.red;
    }

    void Update()
    {
        scoreTxt.text = "Score: " + score;
        highscoreTxt.text = "High Score: " + highscore;
        scoreTxt_d.text = "Your Score: " + score;
        highscoreTxt_d.text = "Your High Score: " + highscore;

        if(Input.GetMouseButtonDown(0))
        {
            Flap.Play();
            Rb.velocity = Vector2.up * jumpForce;
            Vector3 newRotation = new Vector3(0, 0, 20);
            transform.eulerAngles = newRotation;
            StartCoroutine(down());
        }

        IEnumerator down()
        {
            Vector3 newRotation1 = new Vector3(0, 0, 20);
            Vector3 newRotation2 = new Vector3(0, 0, 0);
            Vector3 newRotation3 = new Vector3(0, 0, -20);
            transform.eulerAngles = newRotation1;
            yield return new WaitForSeconds(0.2f);
            transform.eulerAngles = newRotation2;
            yield return new WaitForSeconds(0.2f);
            transform.eulerAngles = newRotation3;
        }

        if(score > highscore)
        {
            highscore = score;

            scoreTxt.color = Color.green;

            PlayerPrefs.SetFloat("HighScore", highscore);
        }

        if(Input.GetKeyDown(KeyCode.I))
        {
            if(PlayerInvicible==false)
            {
                PlayerInvicible=true;
                print("Invicible On");
                CheatTxt.text = "Cheat: On";
                CheatTxt.color = Color.green;
            }
            else
            {
                PlayerInvicible=false;
                print("Invicible Off");
                CheatTxt.text = "Cheat: Off";
                CheatTxt.color = Color.red;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="point")
        {
            score++;
            Score.Play();

            if(PlayerInvicible==true)
            {
                CheatScore++;
            }
            else
            {
                PureScore++;
            }

            PlayerPrefs.SetFloat("PureScore", PureScore);
            PlayerPrefs.SetFloat("CheatScore", CheatScore);
        }

        if(collision.gameObject.tag=="pipa")
        {
            if(PlayerInvicible==false)
            {
                Destroy(gameObject);
                GameOver.SetActive(true);
                Scoremain.SetActive(false);
                Highscoremain.SetActive(false);
                fail++;
                PlayerPrefs.SetFloat("Fail", fail);
                Hit_Sound.Play();
                groundSound.Play();
            }
            else
            {
                print("Invicible");
            }
        }

        if(collision.gameObject.tag=="ground")
        {
            if(PlayerInvicible==false)
            {
                Destroy(gameObject);
                GameOver.SetActive(true);
                Scoremain.SetActive(false);
                Highscoremain.SetActive(false);
                fail++;
                PlayerPrefs.SetFloat("Fail", fail);
                Hit_Sound.Play();
                groundSound.Play();
            }
            else
            {
                print("Invicible");
            }
        }
    }
}
