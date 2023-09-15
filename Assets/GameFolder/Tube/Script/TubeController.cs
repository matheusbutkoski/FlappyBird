using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeController : MonoBehaviour
{

    public float speed;

    public float leftEdge;

    // Start is called before the first frame update
    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1;
    }

    // Update is called once per frame
    void Update()
    {
        move();

        if(transform.position.x < leftEdge){
            Destroy(gameObject);
        }
    }

    void move(){
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
