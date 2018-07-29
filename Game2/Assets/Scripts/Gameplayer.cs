using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplayer : MonoBehaviour {
public GameObject Yun,Git,Ho,Chan;
public static int player1 {get; set;}
public static int player2 {get; set;}
Text HP1;
Text HP2;
Vector3 vec1 = new Vector3(-1.5f,-1,-1);
Vector3 vec2 = new Vector3(2f,-1,-1);
Quaternion qua = new Quaternion(0,0,0,0);
	// Use this for initialization
	void Start () {
		if(player1 == 0)
		{
			GameObject c1 = Instantiate(Yun,vec1,qua);
            c1.tag = "Player1";
		}
		if(player2 == 0)
		{
			GameObject c2 = Instantiate(Yun,vec2,qua);
            c2.tag = "Player2";
		}
		if(player1 == 1)
		{
            GameObject c1 = Instantiate(Git,vec1,qua);
            c1.tag = "Player1";
        }
		if(player2 == 1)
		{
            GameObject c2 = Instantiate(Git,vec2,qua);
            c2.tag = "Player2";
        }
		if(player1 == 2)
		{
            GameObject c1 = Instantiate(Ho,vec1,qua);
            c1.tag = "Player1";
        }
		if(player2 == 2)
		{
            GameObject c2 = Instantiate(Ho,vec2,qua);
            c2.tag = "Player2";
        }
		if(player1 == 3)
		{
            GameObject c1 = Instantiate(Chan,vec1,qua);
            c1.tag = "Player1";
        }
		if(player2 == 3)
		{
            GameObject c2 = Instantiate(Chan,vec2,qua);
            c2.tag = "Player2";
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
