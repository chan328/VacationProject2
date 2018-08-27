using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour {
public Slider SHP1,SHP2;
public GameObject Yun,Git,Ho,Chan,Uh;
public static int player1 {get; set;}
public static int player2 {get; set;}
Text HP1;
Text HP2;
Vector3 vec1 = new Vector3(-1.5f,-1,-1);
Vector3 vec2 = new Vector3(1.5f,-1,-1);   
Quaternion qua = new Quaternion(0,0,0,0);
    // Use this for initialization

    void Start () {	 
		HP1 = GameObject.Find("P1HP").GetComponent<Text>();
		HP2 = GameObject.Find("P2HP").GetComponent<Text>();
		player1 = 4;
		player2 = 4;
		if(player1 == 0)
		{
			SHP1.maxValue = 170;
			Gameplayer.HP1_ = 170;
			GameObject c1 = Instantiate(Yun,vec1,qua);
            c1.tag = "Player1";			
		}
		if(player2 == 0)
		{
			SHP2.maxValue = 170;
			Gameplayer.HP2_ = 170;
			GameObject c2 = Instantiate(Yun,vec2,qua);
            c2.tag = "Player2";
		}
		if(player1 == 1)
		{
			SHP1.maxValue = 160;
			Gameplayer.HP1_ = 160;
            GameObject c1 = Instantiate(Git,vec1,qua);
            c1.tag = "Player1";
        }
		if(player2 == 1)
		{
			SHP2.maxValue = 160;
			Gameplayer.HP2_ = 160;
			GameObject c2 = Instantiate(Git,vec2,qua);
            c2.tag = "Player2";
        }
		if(player1 == 2)
		{
			SHP1.maxValue = 150;
			Gameplayer.HP1_ = 150;
            GameObject c1 = Instantiate(Ho,vec1,qua);
            c1.tag = "Player1";
        }
		if(player2 == 2)
		{
			SHP2.maxValue = 150;
			Gameplayer.HP2_ = 150;
            GameObject c2 = Instantiate(Ho,vec2,qua);
            c2.tag = "Player2";
        }
		if(player1 == 3)
		{
			SHP1.maxValue = 200;
			Gameplayer.HP1_ = 200;
            GameObject c1 = Instantiate(Chan,vec1,qua);
            c1.tag = "Player1";
        }
		if(player2 == 3)
		{
			SHP2.maxValue = 200;
			Gameplayer.HP2_ = 200;
            GameObject c2 = Instantiate(Chan,vec2,qua);
            c2.tag = "Player2";
        }
		if(player1 == 4)
		{
			SHP1.maxValue = 100;
			Gameplayer.HP1_ = 100;
            GameObject c1 = Instantiate(Uh,vec1,qua);
            c1.tag = "Player1";
        }
		if(player2 == 4)
		{
			SHP2.maxValue = 100;
			Gameplayer.HP2_ = 100;
            GameObject c2 = Instantiate(Uh,vec2,qua);
            c2.tag = "Player2";
        }
	}
	
	// Update is called once per frame
	void Update () {
		SHP1.value = Gameplayer.HP1_;
		SHP2.value = Gameplayer.HP2_;
		if(Gameplayer.HP1_<=0)
		Gameplayer.HP1_ = 0;
		if(Gameplayer.HP2_<=0)
		Gameplayer.HP2_ = 0;
		HP1.text = ("HP : "+Gameplayer.HP1_);
		HP2.text = ("HP : "+Gameplayer.HP2_);
	}
}
