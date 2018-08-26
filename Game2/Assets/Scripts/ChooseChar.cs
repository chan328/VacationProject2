using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChooseChar : MonoBehaviour {
    public int[] charnum;
    public bool Second;
    public bool End;
    private int Charnum;
    public int FirstChar, SecondChar;


    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Second = false;
        End = false;
    }
    // Update is called once per frame
    void Update ()
    {
        
	}

    public void OnClick(int num)
    {
        FirstChar = num;
        Second = true;
    }
    public void SecondOnclick(int num)
    {
        SecondChar = num;
        End = true;
        
        SceneManager.LoadScene("StageSelect");
        
    }

    public void Test(int num)
    {
        if(End == true)
        {
            return;
        }
        else if(Second == false)
        {
            OnClick(num);
        }
        else if(Second == true)
        {
            SecondOnclick(num);
        }
    }
}
