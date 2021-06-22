﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI ;


public class DriveCar : MonoBehaviour {
  
     
      
        float  distanceunit = 0f ;

    
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;



     void start () 
     {
         InvokeRepeating ("distance" ,0 , 1 / speed) ;
        
       

     } 
     void FixedUpdate() {
             transform.position += transform.forward * Time.deltaTime *speed;
           
     }
 


    void Update()
    {
        
         
        
        float rotation = CrossPlatformInputManager.GetAxis("Horizontal") * rotationSpeed;
        
        rotation *= Time.deltaTime;
        
        transform.Rotate(0, rotation, 0); 
    }
    private void OnTriggerEnter(Collider other)
 {
    if (other.gameObject.tag == "Nitro")
    {
         speed = speed +10;
            
        
    }
    else 
       if (other.gameObject.tag == "cadena")
    {
         
            speed = speed -10;
        
    }
 }
 
 
 
    
   
   
}