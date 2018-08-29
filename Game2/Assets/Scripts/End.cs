using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Onclick(int num)
    {
        switch(num)
        {
            case 1:
                SceneManager.LoadScene("CharacterChoose");
                break;
            case 2:
                Application.Quit();
                break;
        }
    }
}
