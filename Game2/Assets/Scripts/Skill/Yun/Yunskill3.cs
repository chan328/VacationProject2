using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yunskill3 : MonoBehaviour {
    public bool Can_useSkill3;
    public GameObject Yun;

	// Use this for initialization
	void Start () {
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        Can_useSkill3 = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (this.tag == "Player1")
        {
            if (Can_useSkill3 == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    StartCoroutine(Sk_time());
                }
            }
        }
		else if (this.tag == "Player2")
        {
            if (Can_useSkill3 == true)
            {
                if (Input.GetKeyDown(KeyCode.L))
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
        yield return new WaitForSeconds(10);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }
    IEnumerator Sk_cooltime()
    {
        yield return new WaitForSeconds(30);
        Can_useSkill3 = true;
    }
}
