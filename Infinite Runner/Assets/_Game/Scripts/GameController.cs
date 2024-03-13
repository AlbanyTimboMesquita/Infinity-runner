using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float playerScore;
    public bool gameStart;
    void Start()
    {
       playerScore=0f; 
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStart){
            playerScore += Time.deltaTime;
        }
    }
}
