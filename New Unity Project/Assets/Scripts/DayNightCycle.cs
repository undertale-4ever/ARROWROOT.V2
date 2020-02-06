/*********
 * DayNightCycle.cs
 * By:Esther Strathy
 * 2/6/2020
 * Description: changes from day to night based on current score
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public GameManager GM;
    public MoonandStars MaS;
    public GameObject moonandStars;
    public Vector2 position;
    public GameObject[] prefabs;
    Color daycolor, nightcolor; 
    Camera cm; 
    // Start is called before the first frame update
    void Start()
    {
        //finds scripts to access them later
        GM = FindObjectOfType<GameManager>();
        MaS = FindObjectOfType<MoonandStars>();
        cm = FindObjectOfType<Camera>();
        daycolor = new Color(85f,85f,85f,255f);
        nightcolor = new Color(218f,218f,218f,255f);
    }

    // Update is called once per frame
    void Update()
    {
        changeState();
        //if night, run night function
        if(GM.DayNightState == GameManager.DayNight.Night)
        {
            Night(); 
        }
        else if (GM.DayNightState == GameManager.DayNight.Day)
        {
            Day();
        }
    }
    //changes game state from day to night or vice versa  
    void changeState()
    {
        if(GameManager.score > 700 && GameManager.score < 900)
        {
            GM.DayNightState = GameManager.DayNight.Night; 
        }
        else
        {
            GM.DayNightState = GameManager.DayNight.Day; 
        }
    }

    void Night()
    {
        //includes spawning the moon and stars 
        if (MaS.starmooncount() == true)
        {
            GameObject moonstars = Instantiate(moonandStars, position, Quaternion.identity);
        }
        //invert colors 
        cm.backgroundColor = Color.black;
        //cycles through all given prefabs and changes their colors
        for (int i = 0; i < prefabs.Length; i++)
        {
            prefabs[i].GetComponent<SpriteRenderer>().color = nightcolor;
        }
    }
    void Day()
    {
        //invert colors 
        cm.backgroundColor = Color.white;
        //cycles through all given prefabs and changes their colors
        for (int i = 0; i < prefabs.Length; i++)
        {
            prefabs[i].GetComponent<SpriteRenderer>().color = daycolor; 
        }
    }
}
