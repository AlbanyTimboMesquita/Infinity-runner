using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text txtScore;
    private GameController gameController;
    void Start()
    {
      gameController= FindObjectOfType<GameController>();  
    }

    // Update is called once per frame
    void Update()
    {
       txtScore.text = gameController.playerScore.ToString("0") + "m";
    }
}
