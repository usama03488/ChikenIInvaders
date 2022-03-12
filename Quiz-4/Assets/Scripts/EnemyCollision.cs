using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//this class detect the collision with bullets or player
public class EnemyCollision : MonoBehaviour
{
    private GameManager player;
    private int scorevalue=5;
    public ParticleSystem explosionpartical;
    EnemySpawning enemy;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.Find("Player").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //if enemy collided with bullets enemy will destroy and score added in player scores
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Instantiate(explosionpartical,transform.position,explosionpartical.transform.rotation);
            if (player != null)
            {
                player.Addscore(scorevalue);
            }
        
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        //if enemy collides with player then player life decreased by one
        else if (collision.gameObject.CompareTag("Player"))
        {
            if (player.GetLives() <= 0)
            {
                player.Gameover();

                Destroy(gameObject);
               

                Debug.Log("GameOver");
            }
            else
            {
                player.setLife(1);

                Destroy(gameObject);
            }
           
        }
    }
}
