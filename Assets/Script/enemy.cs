using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemy : MonoBehaviour
{
    public float speed = 8;
    void Start()
    {
        
    }
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.name.StartsWith("mario"))
        { 
            Destroy(target.gameObject);
            Debug.Log("game over");
        }
    }
}