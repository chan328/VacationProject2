using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplayer : MonoBehaviour {
    public ChooseChar ChooseCharacter;
    public Slider SHP1,SHP2;
    public GameObject Yun,Git,Ho,Chan,Uh;
    GameObject Player1, Player2;
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
        
        ChooseCharacter = GameObject.Find("CharSelect").GetComponent<ChooseChar>();
        player1 = ChooseCharacter.FirstChar;
		player2 = ChooseCharacter.SecondChar;		 
		HP1 = GameObject.Find("P1HP").GetComponent<Text>();
		HP2 = GameObject.Find("P2HP").GetComponent<Text>();
		if(player1 == 0)
		{
			SHP1.maxValue = 170;
			HP1_ = 170;
			Player1 = Instantiate(Yun,vec1,qua);
            Player1.tag = "Player1";			
		}
		if(player2 == 0)
		{
			SHP2.maxValue = 170;
			HP2_ = 170;
			Player2 = Instantiate(Yun,vec2,qua);
            Player2.tag = "Player2";
		}
		if(player1 == 1)
		{
			SHP1.maxValue = 160;
			HP1_ = 160;
            Player1 = Instantiate(Git,vec1,qua);
            Player1.tag = "Player1";
        }
		if(player2 == 1)
		{
			SHP2.maxValue = 160;
			HP2_ = 160;
			Player2 = Instantiate(Git,vec2,qua);
            Player2.tag = "Player2";
        }
		if(player1 == 2)
		{
			SHP1.maxValue = 150;
			HP1_ = 150;
            Player1 = Instantiate(Ho,vec1,qua);
            Player1.tag = "Player1";
        }
		if(player2 == 2)
		{
			SHP2.maxValue = 150;
			HP2_ = 150;
            Player2 = Instantiate(Ho,vec2,qua);
            Player2.tag = "Player2";
        }
		if(player1 == 3)
		{
			SHP1.maxValue = 200;
			HP1_ = 200;
            Player1 = Instantiate(Chan,vec1,qua);
            Player1.tag = "Player1";
        }
		if(player2 == 3)
		{
			SHP2.maxValue = 200;
			HP2_ = 200;
            Player2 = Instantiate(Chan,vec2,qua);
            Player2.tag = "Player2";
        }
		if(player1 == 4)
		{
			SHP1.maxValue = 100;
			HP1_ = 100;
            Player1 = Instantiate(Uh,vec1,qua);
            Player1.tag = "Player1";
        }
		if(player2 == 4)
		{
			SHP2.maxValue = 100;
			HP2_ = 100;
            Player2 = Instantiate(Uh,vec2,qua);
            Player2.tag = "Player2";
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(Player1 == null || Player2 == null)
        {
            SceneManager.LoadScene("GameEnd");
        }
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
