using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseStage : MonoBehaviour {
    public int Stagenum;

	// Use this for initialization
	void Start () {
        Stagenum = 0;
        DontDestroyOnLoad(gameObject);
	}
    public void onClick (int num)
    {
        Stagenum = num;
        switch(Stagenum)
        {
            case 1:
                SceneManager.LoadScene("Tample");
                break;
            case 2:
                SceneManager.LoadScene("Stage2");
                break;
            case 3:
                SceneManager.LoadScene("Stage3");
                break;
            case 4:
                SceneManager.LoadScene("Stage4");
                break;
            default:
                Debug.Log("에러에러");
                break;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
