using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UhSkill2 : MonoBehaviour {
    public SpriteRenderer UhRender;
    public Sprite Counter,Ego;
    GameObject Player;
    public GameObject Skill2;
    bool canuse;
	// Use this for initialization
	void Start () {
        UhRender = GetComponent<SpriteRenderer>();
        Player = this.gameObject;
        canuse = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(canuse == true)
        {
            if(gameObject.tag == "Player1")
            {
                if(Input.GetKeyDown(KeyCode.H))
                {
                    Skill2.tag = "P1Uh1";
                    StartCoroutine("Counter1");
                }
            } 
            else if(Player.gameObject.tag == "Player2")
            {
                if(Input.GetKeyDown(KeyCode.Keypad3))
                {
                    Skill2.tag = "P2Uh1";
                    StartCoroutine("Counter2");
                }
	        }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {    
        if(this.tag == "Untagged")
        {
            if(other.tag !="Ground"&&other.tag !="Player1"&&other.tag !="Player2"&&other.tag!="Portal1" &&other.tag !="Portal2") 
            {      
                if(other.transform.localScale.x < 0)
                {
                    GameObject attack = Instantiate(Skill2, this.transform.position + new Vector3(0.5f, 0.18f, -1), Quaternion.identity);
                    attack.transform.localScale = new Vector3(0.8f, 0.8f, 0);
                    StartCoroutine("Skill2cooltime");
                }
                else if(other.transform.localScale.x > 0)
                {
                    GameObject attack = Instantiate(Skill2, this.transform.position + new Vector3(-0.5f, 0.18f, -1), Quaternion.identity);
                    attack.transform.localScale = new Vector3(-0.8f, 0.8f, 0);
                    StartCoroutine("Skill2cooltime");
                }
            }
            this.tag = "Finish";
        }  
    }
    IEnumerator Counter1()
    {
        UhRender.sprite = Counter;
        this.tag = "Untagged";
        yield return new WaitForSeconds(2);
        UhRender.sprite = Ego;
        this.tag = "Player1";
    }
    IEnumerator Counter2()
    {
        UhRender.sprite = Counter;
        this.tag = "Untagged";
        yield return new WaitForSeconds(2);
        UhRender.sprite = Ego;
        this.tag = "Player2";
    }
    IEnumerator Skill2cooltime()
    {
        canuse = false;
        yield return new WaitForSeconds(0);
        canuse = true;
    }
}

