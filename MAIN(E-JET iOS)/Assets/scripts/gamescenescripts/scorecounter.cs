﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour
{
    // Start is called before the first frame update
    public static scorecounter instance;
    private float score=0;
    public Text scoretext;
    public Text highscore;
     void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
       
    }
    void Start()
    {
        highscore.text = PlayerPrefs.GetFloat("highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawner.instance.stopspawning == false)
        {
            score =score+ Time.deltaTime;
            score = Mathf.Round(score * 1000f) / 1000f;
            scoretext.text = score.ToString();
            if(score>PlayerPrefs.GetFloat("highscore",0))
            {
                PlayerPrefs.SetFloat("highscore",score);
            }
        }
        else
        {
            
        }
    }
     

    
        
    
}
