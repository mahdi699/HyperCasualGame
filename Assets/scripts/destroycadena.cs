using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class destroycadena : MonoBehaviour
{
  
  private  float currentTime = 0f ;
     private  timercontroller timercontroller ; 
   
  void Awake () 
 {
     timercontroller = GameObject.FindObjectOfType<timercontroller> () ;
 }
  private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "Player")
    {
         
            Destroy (gameObject) ;
          timercontroller.currentTime -= 20 ; 
    }
}
}
