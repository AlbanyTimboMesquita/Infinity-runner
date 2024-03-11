using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAdapter : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] spriteRenderers;
    private void Awake() {
        float tempTransform =  spriteRenderers[0].sprite.bounds.size.x;
        for (int i = 0; i < spriteRenderers.Length; i++)
        {
            spriteRenderers[i].transform.position = new Vector2(tempTransform*i,transform.position.y);
        }
    }

}
