using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitMove : CharMove {
public static bool Shield {get; set;}
public static int HP_1{get; set;}
    void Start()
    {
        Shield = false;
        HP_1 = 160;         
    }

    void FixedUpdate()
    {
        if(this.tag == "Player1")
        base.Move();
        if(this.tag == "Player2")
        base.Move2();
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
        if(!Shield)
        {
            if(this.tag == "Player1")
            {
                if(other.gameObject.tag == "YunSkill_2")
                {
                    if(Yunskill3.UsingSkill3 == true)
                    {
                        Gameplayer.HP1_ -= 40;
                    }
                    else
                    Gameplayer.HP1_-=20;
                }
                if(other.gameObject.tag == "YunAttack_2")
                {
                    if(Yunskill3.UsingSkill3 == true)
                    {
                        Gameplayer.HP1_ -= 20;
                    }
                    else
                    Gameplayer.HP1_ -= 10;
                }
            }
            if(this.tag == "Player2")
            {
                if(other.gameObject.tag == "YunSkill1")
                {
                    if (Yunskill3.UsingSkill3 == true)
                    {
                        Gameplayer.HP2_ -= 40;
                    }
                    else
                        Gameplayer.HP2_ -= 20;
                }
                if(other.gameObject.tag == "YunAttack")
                {
                    if (Yunskill3.UsingSkill3 == true)
                    {
                        Gameplayer.HP2_ -= 20;
                    }
                    else
                    Gameplayer.HP2_ -= 10;
                }
            }
        }
    }
    
}