using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundWidth : MonoBehaviour
{
    private SpriteRenderer sprite;
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    private void Start() {
        Vector3 escalaTemp = transform.localScale;

        var largura = sprite.bounds.size.x;
        //var altura = sprite.bounds.size.y;

        var alturaWorld = Camera.main.orthographicSize*2f;
        var larguraWorld = alturaWorld/Screen.height*Screen.width;

        escalaTemp.x = larguraWorld/largura;
       // escalaTemp.y =alturaWorld/altura;

        transform.localScale=escalaTemp;

    }
}
