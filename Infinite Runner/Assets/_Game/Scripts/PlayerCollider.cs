using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target) {
        if(target.gameObject.CompareTag("Obstacle")){
            Player tempPlayer =  GetComponent<Player>();
            tempPlayer.isDie = true;
        }
    }
}
