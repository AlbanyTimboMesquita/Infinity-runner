using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   private Transform playerTransform;
    [SerializeField] private float offset;
    void Start()
    {
      playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(playerTransform.position.x + offset,this.transform.position.y,this.transform.position.z);
    }
}
