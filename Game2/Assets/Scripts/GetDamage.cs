﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDamage : CharMove {
    Text Hp1, Hp2;
    Slider sliderP1, sliderP2;
	// Use this for initialization
	void Start () {
        
	}

    private void FixedUpdate()
    {
        if(this.tag == "Player1")
        {
            if(Gameplayer.HP1_ <= 0)
            {
                Destroy(GameObject.FindGameObjectWithTag("Player1"));
            }
        }
        else if(this.tag == "Player2")
        {
            if(Gameplayer.HP2_ <= 0)
            {
                Destroy(GameObject.FindGameObjectWithTag("Player2"));
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
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