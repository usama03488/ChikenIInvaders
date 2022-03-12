using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DifficulryMode : MonoBehaviour
{
    private Button button;
    public GameManager player;
    public int Difficulty;
    // Start is called before the first frame update
    //In this class we select the difficulty mode
    void Start()
    {
        button= GetComponent<Button>();
        button.onClick.AddListener(Setdifficulty);
        player=GameObject.Find("Player").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Setdifficulty()
    {
        Debug.Log(gameObject.name + "was clicked");
        player.StartGame(Difficulty);
    }
}
