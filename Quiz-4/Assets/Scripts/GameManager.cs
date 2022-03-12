using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textscore;
    public TextMeshProUGUI gameover;
    public int score ;
    private int PlayerLives;
    public GameObject Titlescreen;
    public GameObject restartButton;
  public int SpawnRate = 1;
    public GameObject GamePause;
    private bool Ispaused;
    public Toggle ONOFF;
    public AudioSource audio;
    // Start is called before the first frame update
    //IN this class im doinf the managers task
    void Start()
    {


    }

    // Update is called once per frame
    //IN the update fucntion if player press p game will pause
    void Update()
    {
       
        if (Input.GetKey(KeyCode.P)){
            Gamepause();
        }
    }
    //this function add the score and dislay in the game
    public void Addscore(int addnumber)
    {
        score += addnumber;
        textscore.text = "Score:" + score;
    }
    //this function activate the game over screen when game overs
    public void Gameover()
    {

        gameover.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }
    //player get three lifes and life subtracts every time when player collides with enemy
    public void setLife(int life)
    {
        PlayerLives -= life;
    }
    public int GetLives() {
        return PlayerLives;
    }
    public void Restartplayer()
    {
        PlayerLives = 3;
    }

    //this function start the game 
    public void StartGame(int diff)
    {
             score = 0;
            PlayerLives = 3;
        SpawnRate = SpawnRate / diff;
        Titlescreen.gameObject.SetActive(false);
}
    //this function pause the game
    public void Gamepause()
    {
        if (!Ispaused)
        {
            Ispaused = true;
            GamePause.gameObject.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            Ispaused = false;
            GamePause.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
    //this function play the audio 
    public void audiomanager()
    {
        if (ONOFF.isOn)
        {
            Debug.Log("SOUND PLAYED");
            audio.Play();
        }
        else
        {
            Debug.Log("SOUND PLAYED");
            audio.Stop();
        }
    }
}

