using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanSkill2Tag : MonoBehaviour {
    public GameObject Player;
	// Use this for initialization
	void Start () {
        Player = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if(Player.tag == "Player1")
        {
            tag = "P1ChanSkill2";
        }
        else if(Player.tag == "Player2")
        {
            tag = "P2ChanSkill2";
        }
	}
}
