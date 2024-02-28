using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour
{
    

    public static ScoreManager instance;

    public GameObject dialougeBox;
    public Text dialougeText;
    public string Dialog;
    public bool dialogActive;
    public Text scoreText;
    public static int score;
    public string lore1;
    private void Awake()
    {
        instance = this;

        scoreText.text = score.ToString();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }
    void Update()
    {

    }
    

    

  public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString();

        if(score == 10)
        {
            lore1 = "This place is so quiet. Last time i was in a noisy place was... when she was still alive...";
        }
    }


}
