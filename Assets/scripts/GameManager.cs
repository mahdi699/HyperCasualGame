﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class GameManager : MonoBehaviour
{
    
  
    void Update()
    {
      if(transform.position.y < -1)
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }
    
}