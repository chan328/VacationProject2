using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yunskill3 : MonoBehaviour {
    public bool Can_useSkill3 = true;
    public static bool P1UsingSkill3 { get; set; }
    public static bool P2UsingSkill3 { get; set; }
    public GameObject Yun;

	// Use this for initialization
	void Start () {
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        P1UsingSkill3 = false;
        P2UsingSkill3 = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (this.tag == "Player1")
        {
            if (Can_useSkill3 == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    P1UsingSkill3 = true;
                    StartCoroutine(Sk_time());
                }
            }
        }
		else if (this.tag == "Player2")
        {
            if (Can_useSkill3 == true)
            {
                if (Input.GetKeyDown(KeyCode.Keypad0))
                {                    
                    P2UsingSkill3 = true;
                    StartCoroutine(Sk_time());
                }
            }
        }
	}
    IEnumerator Sk_time()
    {
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        Can_useSkill3 = false;
        yield return new WaitForSeconds(5);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        StartCoroutine("Sk_cooltime");
    }
    IEnumerator Sk_cooltime()
    {
        if(this.tag == "Player1")
        {
            P1UsingSkill3 = false;
        }
        else if(this.tag == "Player2")
        {
            P2UsingSkill3 = false;
        }
        yield return new WaitForSeconds(30);
        Can_useSkill3 = true;
    }
}
