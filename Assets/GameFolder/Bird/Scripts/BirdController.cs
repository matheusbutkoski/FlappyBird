using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Transform skin;

    public float impulse;

    private Rigidbody2D rb;

    public GameManager game;



    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        fly();
    }

    void fly(){
        if(Input.GetMouseButtonDown(0)){

            skin.GetComponent<Animator>().Play("Fly", -1);
            rb.AddForce(new Vector2(0, impulse), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Score")){
            game.IncreaseScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
             game.GameOver();
    }

 }

