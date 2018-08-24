using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanSKill2 : MonoBehaviour {
    bool Canuse;
    GameObject Player;

	// Use this for initialization
	void Start () {
        Canuse = true;
        Player = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, -5,Space.World);
        if(Canuse == true)
        {
            if (Player.tag == "Player1")
            {
                if (Input.GetKeyDown(KeyCode.H))
                {
                    gameObject.tag = "Player1";
                    transform.GetChild(0).gameObject.SetActive(true);
                    StartCoroutine("Skiil2");
                }
            }
            else if (Player.tag == "Player2")
            {
                if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    gameObject.tag = "Player2";
                    transform.GetChild(0).gameObject.SetActive(true);
                    StartCoroutine("Skiil2");
                }
            }
        }
	}
    IEnumerator Skiil2()
    {
        Canuse = false;
        yield return new WaitForSeconds(5);
        transform.GetChild(0).gameObject.SetActive(false);
        StartCoroutine("Skill2cooltime");
    }

    IEnumerator Skill2cooltime()
    {
        yield return new WaitForSeconds(15);
        Canuse = true;
    }
}
