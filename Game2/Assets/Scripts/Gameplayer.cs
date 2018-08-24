using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplayer : MonoBehaviour {
public Slider SHP1,SHP2;
public GameObject Yun,Git,Ho,Chan;
public static int player1 {get; set;}
public static int player2 {get; set;}
public static int HP1_ {get; set;}
public static int HP2_ {get; set;}
Text HP1;
Text HP2;
Vector3 vec1 = new Vector3(-1.5f,-1,-1);
Vector3 vec2 = new Vector3(1.5f,-1,-1);   
Quaternion qua = new Quaternion(0,0,0,0);
	// Use this for initialization
	void Start () {
		player1 = 1;
		player2 = 0;		 
		HP1 = GameObject.Find("P1HP").GetComponent<Text>();
		HP2 = GameObject.Find("P2HP").GetComponent<Text>();
		if(player1 == 0)
		{
			SHP1.maxValue = 170;
			HP1_ = 170;
			GameObject c1 = Instantiate(Yun,vec1,qua);
            c1.tag = "Player1";			
		}
		if(player2 == 0)
		{
			SHP2.maxValue = 170;
			HP2_ = 170;
			GameObject c2 = Instantiate(Yun,vec2,qua);
            c2.tag = "Player2";
		}
		if(player1 == 1)
		{
			SHP1.maxValue = 160;
			HP1_ = 160;
            GameObject c1 = Instantiate(Git,vec1,qua);
            c1.tag = "Player1";
        }
		if(player2 == 1)
		{
			SHP2.maxValue = 160;
			HP2_ = 160;
			GameObject c2 = Instantiate(Git,vec2,qua);
            c2.tag = "Player2";
        }
		if(player1 == 2)
		{
			SHP1.maxValue = 150;
			HP1_ = 150;
            GameObject c1 = Instantiate(Ho,vec1,qua);
            c1.tag = "Player1";
        }
		if(player2 == 2)
		{
			SHP2.maxValue = 150;
			HP2_ = 150;
            GameObject c2 = Instantiate(Ho,vec2,qua);
            c2.tag = "Player2";
        }
		if(player1 == 3)
		{
			SHP1.maxValue = 200;
			HP1_ = 200;
            GameObject c1 = Instantiate(Chan,vec1,qua);
            c1.tag = "Player1";
        }
		if(player2 == 3)
		{
			SHP2.maxValue = 200;
			HP2_ = 200;
            GameObject c2 = Instantiate(Chan,vec2,qua);
            c2.tag = "Player2";
        }

	}
	
	// Update is called once per frame
	void Update () {
		SHP1.value = HP1_;
		SHP2.value = HP2_;
		if(HP1_<=0)
		HP1_ = 0;
		if(HP2_<=0)
		HP2_ = 0;
		HP1.text = ("HP : "+HP1_);
		HP2.text = ("HP : "+HP2_);
	}
}
