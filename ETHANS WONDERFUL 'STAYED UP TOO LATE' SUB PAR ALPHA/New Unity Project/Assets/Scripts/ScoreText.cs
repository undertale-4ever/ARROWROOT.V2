using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update

    public Text highScore;

    public void Score()
    {
        Text myText = GetComponent<Text>();
        myText.text = FindObjectOfType<Score>().playerScore.ToString();


    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score();
    }
}
