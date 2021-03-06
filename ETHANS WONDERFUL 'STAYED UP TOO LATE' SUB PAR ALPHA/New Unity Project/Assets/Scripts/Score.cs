﻿/* Score
 * By: Ethan Young
 * Description: The player's score counts up by 10 per second until the player dies.
 * Last Updated: 1/31/19
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    
    public int highScore = 0;
    float speedSet;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void FixedUpdate()
    {
        //set the speed of the timer
        speedSet += 1 * Time.deltaTime * 5;
        //Round the timer to an integer
        //uses score from game manager script
        GameManager.score = Mathf.RoundToInt(speedSet);
    }
}
