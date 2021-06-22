using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class distencecount : MonoBehaviour
{   
     private  float  distanceunit = 0f ;
      [SerializeField] Text  distancemove ;
       
        
    

 
  void Update () 
  {
  
    
          distanceunit += 1 ;
       
    distancemove.text = distanceunit.ToString ("00") ; 
    
  }
 
 }
