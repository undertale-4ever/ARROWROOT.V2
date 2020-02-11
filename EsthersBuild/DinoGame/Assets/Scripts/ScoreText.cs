using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update

    Text highScore;
    Text myText;
    void Start()
    {
        myText = GetComponent<Text>();
    }
    public void Score()
    {
        myText.text = GameManager.score.ToString();
    }


   

    // Update is called once per frame
    void Update()
    {
        Score();
    }
}
