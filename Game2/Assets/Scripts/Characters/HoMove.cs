using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ho : CharMove {
public static int HP_2{get; set;}
int a;
    void Start()
    {
        if(transform.position.x == -1.5f)
        a = 1;
        if(transform.position.x == 2f)
        a = 2;
        HP_2 = 90; 
        Gameplayer.player2 =1;   
    }

    void FixedUpdate()
    {
        
        if(a==1)
        base.Move();
        if(a==2)
        base.Move2();
        if(transform.position.y<-10)
        {
            HP_2 -= 20;
            transform.position = new Vector3(0,0,0);
        }
    }

    void Update()
    {
        if(HP_2<=0)
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isJumping = true;
        }
    }
}