using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanSkill2Tag : MonoBehaviour {
    public GameObject Player;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Player = transform.parent.gameObject;
        if(Player.tag == "Player1")
        {
            tag = "P1Chan2";
        }
        else if(Player.tag == "Player2")
        {
            tag = "P2Chan2";
        }
	}
}
