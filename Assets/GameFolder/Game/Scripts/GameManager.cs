using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private int score;

    public BirdController bird;

    public Text scoreText;

    public GameObject startButton;

    public GameObject restartButton;

    public GameObject gameOver;

    public GameObject getReady;


    private void Awake(){
        Pause();
        getReady.SetActive(true);
        
    }

    public void Play(){
        score = 0;
        scoreText.text = score.ToString();
        gameOver.SetActive(false);
        getReady.SetActive(false);
        startButton.SetActive(false);
        Time.timeScale = 1;
        bird.enabled = true;
    }

    public void Pause(){
        Time.timeScale = 0;
        bird.enabled = false;
    
    }

    public void GameOver(){
        gameOver.SetActive(true);
        restartButton.SetActive(true);
        Pause();
    }

    public void restartGame(){
        SceneManager.LoadScene(0);
    }

    public void IncreaseScore(){
        score++;
        scoreText.text = score.ToString();
    }
}
