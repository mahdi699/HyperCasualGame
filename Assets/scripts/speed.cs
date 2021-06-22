using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class speed : MonoBehaviour
{

    public  float currentspeed  =20 ;
    private DriveCar DriveCar ;
    [SerializeField] Text countspeed ;

 void Start()
    {
      
    }

    void Awake () 
 {
     DriveCar = GameObject.FindObjectOfType<DriveCar> () ;
 }
    
     
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
          currentspeed=  DriveCar.speed  ; 
        countspeed.text = currentspeed.ToString("00") ;  
    }
     
}
