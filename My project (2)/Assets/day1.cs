using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class day1 : MonoBehaviour
{
    public  Text ScoreText;
   public  int Score = 0;

    public int inc = 1;
    public Text IncText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void Increase()
    { Score += inc;
        ScoreText.text = Score.ToString();
    }
    public void shop()
    
    {
        if (Score >= 5) 
        { Score -= 5; }
        inc += 1;
        IncText.text = " increase " + inc;
        ScoreText.text = Score.ToString();
    }
}
