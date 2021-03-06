﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour {
    public float movePower = 2f;
    public float jumpPower = 3f;
    Vector3 movement;
    public bool isJumping = false;
    Rigidbody2D rig;
	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Move()
    {
        Vector3 movevelo = Vector3.zero;
            if(Input.GetKey(KeyCode.W))
            {
                Jump();
            }
            if (Input.GetKey(KeyCode.A))
            {
                movevelo = Vector3.left;
                transform.localScale = new Vector3(-0.5f,0.5f,1);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                movevelo = Vector3.right;
                transform.localScale = new Vector3(0.5f,0.5f,1);
            }
        if(transform.position.y<-10)
        {
            Gameplayer.HP1_ -= 20;
            transform.position = new Vector3(0,0,0);
        }       
        transform.position += movevelo * movePower * Time.deltaTime;
        if(Gameplayer.HP1_<=0)
        Destroy(gameObject);
    }
    public void Move2()
	{
		Vector3 movevelo = Vector3.zero;
            if(Input.GetKey(KeyCode.UpArrow))
            {
                Jump();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                movevelo = Vector3.left;
                transform.localScale = new Vector3(-0.5f,0.5f,1);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                movevelo = Vector3.right;
                transform.localScale = new Vector3(0.5f,0.5f,1);
            }
        if(transform.position.y<-10)
        {
            Gameplayer.HP2_ -= 20;
            transform.position = new Vector3(0,0,0);
        }        
        transform.position += movevelo * movePower * Time.deltaTime;
        if(Gameplayer.HP2_<=0)
        Destroy(gameObject);
	}
	public void Jump()
    {
		rig = GetComponent<Rigidbody2D>();       
        if (!isJumping) return;

        rig.velocity = Vector2.zero;
        Vector2 jumpvelocity = new Vector2(0, jumpPower);

        rig.AddForce(jumpvelocity, ForceMode2D.Impulse);

        isJumping = false;
    }
}
