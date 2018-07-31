using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yunskill3 : MonoBehaviour {
    public static bool Can_useSkill3;
    public static bool UsingSkill3 {get; set;}
    public GameObject Yun;

	// Use this for initialization
	void Start () {
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        Can_useSkill3 = true;
	}
	
	// Update is called once per frame
	void Update () {
        Component g = new Component();

        if (this.tag == "Player1")
        {
            if (Can_useSkill3 == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
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
                    StartCoroutine(Sk_time());
                }
            }
        }
	}
    IEnumerator Sk_time()
    {
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        Can_useSkill3 = false;
        UsingSkill3 = true;
        yield return new WaitForSeconds(5);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        StartCoroutine("Sk_cooltime");
    }
    IEnumerator Sk_cooltime()
    {
        UsingSkill3 = false;
        yield return new WaitForSeconds(30);
        Can_useSkill3 = true;
    }
}
