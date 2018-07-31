using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoSkill1 : MonoBehaviour {
    public static bool HoSkill1_on;
    public bool CanUseskill1;

	// Use this for initialization
	void Start () {
        HoSkill1_on = false;
        CanUseskill1 = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(CanUseskill1 == true)
        {
            if(this.tag == "Player1")
            {
                if(Input.GetKeyDown(KeyCode.G))
                {
                    HoSkill1_on = true;
                    StartCoroutine("EffectofSkill1");
                }
            }
            else if (this.tag == "Player2")
            {
                if(Input.GetKeyDown(KeyCode.Keypad2))
                {
                    HoSkill1_on = true;
                    StartCoroutine("EffectofSkill1");
                }
            }
        }
	}

    IEnumerator EffectofSkill1()
    {
        CanUseskill1 = false;
        yield return new WaitForSeconds(3);
        HoSkill1_on = false;
        StartCoroutine("Skill1cool");
    }
    IEnumerator Skill1cool()
    {
        yield return new WaitForSeconds(10);
        CanUseskill1 = true;
    }
}
