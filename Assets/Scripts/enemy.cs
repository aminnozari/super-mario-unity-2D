using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
       GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.name.StartsWith("marioooo"))
        {
            Destroy(target.gameObject);
            Debug.Log("game over");
        }
    }
}