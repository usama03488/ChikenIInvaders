using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this class spawn the enemies with respect to its difficulty level
public class EnemySpawning : MonoBehaviour
{
    public GameObject Enemyobj;
    public bool IsgameActive;
    public GameManager player; 
    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("Player").GetComponent<GameManager>();
      InvokeRepeating("EnemyInst", 1, player.SpawnRate);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnemyInst()
    {
        if (GameObject.Find("Player").GetComponent<GameManager>().GetLives() >0)
        {
            float i = Random.Range(-9, 9);
            Instantiate(Enemyobj, new Vector2(i, 10f), transform.rotation);
        }
       
      
        
    }
    public void isGameover()
    {
        IsgameActive = true;
    }
    public void RestartGame()
    {
        GameObject.Find("Player").GetComponent<GameManager>().Restartplayer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
