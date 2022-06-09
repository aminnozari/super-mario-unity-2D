
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    private Rigidbody2D myBody;
    public float speed = 5;
    public float jumpHeight = 5;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float a = Input.GetAxisRaw("Horizontal");
        myBody.velocity = new Vector2(a*speed,myBody.velocity.y);

        if(Input.GetKeyDown(KeyCode.UpArrow))
            myBody.velocity += Vector2.up*jumpHeight;
    }
}