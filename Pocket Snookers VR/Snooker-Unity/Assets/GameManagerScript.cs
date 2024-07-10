using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    private GameObject[] balls;
    public GameObject cue;
    public GameObject cueball;
    private bool allAtRest;
    private bool isStationary;
    public GameObject cam;
    public GameObject pointer;
    public GameObject tip;
    public GameObject camOrient;
    public bool isfoul;
    public int score;
    public int shots;
    public float scoreshot;
    public float highscore;
    public GameObject canvas;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreshotText;
    public TextMeshProUGUI modeText;
    public TextMeshProUGUI instructionText;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI displayText;

    void Start()
    {
        score = 0;
        shots = 0;
        isfoul = false;
    }

    void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().name == "OpeningScene" || SceneManager.GetActiveScene().name == "GameOverScene")
        {
            if (Input.GetButton("C"))
            {
                SceneManager.LoadScene("GameScene");
            }
        }

        HandlingCanvas();

        balls = GameObject.FindGameObjectsWithTag("Balls");
        if (balls.Length == 1 && balls[0].gameObject.name == "CueBall")
        {
            EndGame();
        }

        if (cue.GetComponent<StickScript>().shottaken)
        {
            allAtRest = false;
            isStationary = true;
            foreach (GameObject ball in balls)
            {
                if (ball.GetComponent<Rigidbody>().velocity.magnitude < 0.01f)
                    continue;
                else
                {
                    isStationary = false;
                    break;
                }
            }
            if (isStationary)
                allAtRest = true;

            if (cue.GetComponent<StickScript>().shot_mode && allAtRest)
            {
                if (isfoul)
                {
                    cueball.transform.position = cue.GetComponent<StickScript>().initballpos;
                    cueball.GetComponent<MeshRenderer>().enabled = true;
                    isfoul = false;
                }

                cue.transform.position = cueball.transform.position;
                Vector3 pos = new Vector3(0.615f, 0 , 0);
                cue.transform.Translate(pos, Space.Self);

                // if (isfoul)
                // {
                //     Vector3 newV = new Vector3(0.5f, 0, 0);
                //     cue.transform.Translate(newV, Space.Self);
                // }

                Quaternion rot = cue.transform.rotation;
                if (Mathf.Abs(tip.transform.position.x - cueball.transform.position.x) > 1f)
                {
                    if(rot.y < 0f)
                        rot.y += 180f;
                }
                cue.transform.rotation = rot;

                shots++;
                scoreText.text = "Score: " + score;
                scoreshot = (float) score / shots;
                cue.GetComponent<MeshRenderer>().enabled = true;
                cue.GetComponent<StickScript>().shot_mode = false;
                cue.GetComponent<StickScript>().rotation_mode = true;
                cue.GetComponent<StickScript>().shottaken = false;
                cue.GetComponent<StickScript>().lerpon = false;

                displayText.text = "";
                modeText.text = "Mode: Rotation";
                instructionText.text = "Joystick: Left/Right\nPress A to continue";
                pointer.SetActive(true);

                cam.transform.position = camOrient.transform.position;
                cam.transform.rotation = cue.GetComponent<StickScript>().temprot;
            }
        }
    }

    private void HandlingCanvas()
    {
        if (shots == 0)
            scoreshotText.text = "Score/Shot: ";
        else
        {
            scoreshot = Mathf.Round(scoreshot * 100.0f) * 0.01f;
            scoreshotText.text = "Score/Shot: " + scoreshot.ToString("F2");
        }

        highscore = PlayerPrefs.GetFloat("HighScore", 0f);
        highscoreText.text = "High Score: " + highscore.ToString("F2");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("GameOverScene");
        if (scoreshot > highscore)
        {
            highscore = scoreshot;
            PlayerPrefs.SetFloat("HighScore", highscore);
        }
        //scoreshotText.text = "Score/Shot: " + scoreshot.ToString("F2");
        //highscoreText.text = "High Score: " + highscore.ToString("F2");
    }
}
