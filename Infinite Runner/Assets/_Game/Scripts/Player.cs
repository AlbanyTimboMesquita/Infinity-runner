using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed,jumpForce;
    [HideInInspector] public Rigidbody2D myRB;
    public bool isGround,isMoving,isDie;
    void Start()
    {
        Initialize();   
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving){
            transform.Translate(Vector2.right*(speed*Time.deltaTime),Space.World);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }   
    }
    private void Restart(){
        if(isDie){
            isDie=false;
            //animação de die false
        }
    }
    private void Die(){
        if(isDie){
            isMoving = false;
            //animação de dead true
            //animação de run false
        }
    }
    private void Initialize(){
        myRB = GetComponent<Rigidbody2D>();
        isGround = true;
        isMoving = false;
        isDie = false;
        
        InvokeRepeating("CheckOnGround",0.1f,0.1f);
        InvokeRepeating("Run",0.1f,0.1f);
        InvokeRepeating("Die",0.1f,0.1f);
    }
    void Run(){
        if(isMoving){
            //animação de run true
            return;
        }
    }
    public void Jump(){
        if(myRB.velocity.y==0 && isMoving){
            myRB.AddForce(transform.up * jumpForce);
            isGround = false;
            //animação de jump true
        }
    }
    void CheckOnGround(){
        if(myRB.velocity.y ==0 && !isGround){
            isGround=true;
            //animação de jump false
        }
    }
}
