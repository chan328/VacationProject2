﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitMove : CharMove {
public static bool Shield {get; set;}
public static int HP_1{get; set;}
public int StunNum;
public bool stun;
Rigidbody2D gitrig;
    void Start()
    {
        stun = false;
        gitrig = GetComponent<Rigidbody2D>();
        Shield = false;       
    }

    void FixedUpdate()
    {
        if(stun == false)
        {
            if(this.tag == "Player1")
            base.Move();
            if(this.tag == "Player2")
            base.Move2();
        }       
    }

    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isJumping = true;
        }
    }
     private void OnTriggerEnter2D(Collider2D other) {
        if(this.tag == "Player1")
        {
            if(other.gameObject.tag == "P2Git1")
            {          
                gitrig.AddForce(new Vector2(200 * other.gameObject.transform.localScale.x,0));
            }           
            if(other.gameObject.tag == "P2Git2"||other.gameObject.tag == "P2Git3")
            {               
                StartCoroutine("isStun");                             
            }
        }
        else
        {
            if(other.gameObject.tag == "P1Git1")
            {          
                gitrig.AddForce(new Vector2(200 * other.gameObject.transform.localScale.x,0));
            }           
            if(other.gameObject.tag == "P1Git2"|| other.gameObject.tag == "P1Git3")
            {                
                StartCoroutine("isStun");                             
            }
        }

        if(Shield == false)
        {
            if (this.tag == "Player1")
            {
                switch (other.tag)
                {
                    case "P2Yun0":
                        if (Yunskill3.P2UsingSkill3 == true)
                            Gameplayer.HP1_ -= 20;
                        else
                            Gameplayer.HP1_ -= 10;
                        break;
                    case "P2Yun1":
                        if (Yunskill3.P2UsingSkill3 == true)
                            Gameplayer.HP1_ -= 40;
                        else
                            Gameplayer.HP1_ -= 20;
                        break; 
                    case "P2Git0":
                        Gameplayer.HP1_ -= 10;
                        break;               
                    case "P2Git1":
                        Gameplayer.HP1_ -= 10;
                        break;
                    case "P2Git2":
                        Gameplayer.HP1_ -= 8;
                        break;     
                    case "P2Git3":
                        Gameplayer.HP1_ -= 25;
                        break;           
                    case "P2Ho1":
                        Gameplayer.HP1_ -= 30;
                        break;
                    case "P2Ho2":
                        Gameplayer.HP1_ -= 20;
                        break;
                    case "P2Ho0":
                        if (HoSkill1.HoSkill1_on == true)
                        {
                            Gameplayer.HP1_ -= 10;
                            if(Gameplayer.HP2_<=140)
                            Gameplayer.HP2_ += 10;
                            else
                            Gameplayer.HP2_ = 150;
                        }
                        else
                            Gameplayer.HP1_ -= 10;
                        break;               
                }
            }
            else if (this.tag == "Player2")
            {
                switch (other.tag)
                {
                    case "P1Yun0":
                        if (Yunskill3.P1UsingSkill3 == true)
                            Gameplayer.HP2_ -= 20;
                        else
                            Gameplayer.HP2_ -= 10;
                        break;
                    case "P1Yun1":
                        if (Yunskill3.P1UsingSkill3 == true)
                            Gameplayer.HP2_ -= 40;
                        else
                            Gameplayer.HP2_ -= 20;
                        break;       
                    case "P1Git0":
                        Gameplayer.HP2_ -= 10;
                        break;         
                    case "P1Git1":
                        Gameplayer.HP2_ -= 10;
                        break;
                    case "P1Git2":
                        Gameplayer.HP2_ -= 8;
                        break;  
                    case "P1Git3":
                        Gameplayer.HP2_ -= 25;
                        break; 
                    case "P1Ho0":
                        if (HoSkill1.HoSkill1_on == true)
                        {
                            Gameplayer.HP2_ -= 10;
                            if(Gameplayer.HP1_<=140)
                            Gameplayer.HP1_ += 10;
                            else
                            Gameplayer.HP1_ = 150;                        
                        }
                        else
                        Gameplayer.HP2_ -= 10;
                        break;              
                    case "P1Ho1":
                        Gameplayer.HP2_ -= 30;
                        break;
                    case "P1Ho2":
                        Gameplayer.HP2_ -= 20;
                        break;                              
                }
            }
        }
    }
    IEnumerator isStun()
    {
        stun = true;
        yield return new WaitForSeconds(0.5f);
        stun = false;
    }
    
}