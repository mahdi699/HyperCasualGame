using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
using UnityEngine.UI; 
public class GameOverScene : MonoBehaviour
{ 
private  float  distanceunit = 0f ; 

     public Text  dismove ;
       
        
    

 
  void Start () 
{
       
    dismove.text = distanceunit.ToString () ; 
  }
 
    
   public void restartbutton ()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1 );
   }
    public void quittomenu () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2 ) ;
    } 
}
