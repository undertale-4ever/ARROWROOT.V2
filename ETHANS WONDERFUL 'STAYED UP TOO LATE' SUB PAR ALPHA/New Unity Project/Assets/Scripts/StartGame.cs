﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartTheGame()
    {

        SceneManager.LoadScene("MainLevel");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
