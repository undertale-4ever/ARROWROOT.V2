/* Score
 * By: Ethan Young
 * Description: The player's score counts up by 10 per second until the player dies.
 * Last Updated: 1/31/19
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float playerScore;
    public Text highScore;
    float speedSet;

    // Start is called before the first frame update
    void Start()
    {
        //Set the player Score to zero to start
        playerScore = 0;

        highScore.text = PlayerPrefs.GetInt("HI", 0).ToString();
    }
   
    // Update is called once per frame
    void FixedUpdate()
    {
        //set the speed of the timer
        speedSet += 1 * Time.deltaTime * (float)6.75;
        //Round the timer to an integer
        playerScore = Mathf.RoundToInt(speedSet);

        if(playerScore > PlayerPrefs.GetInt("HI", 0))
        {
            PlayerPrefs.SetInt("HI", (int)playerScore);
        }
        
          
    }

   
}
