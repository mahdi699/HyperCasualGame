using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;
using UnityEngine.SceneManagement; 

public class timercontroller : MonoBehaviour
{
     public  float currentTime = 0f ;
     float startTime = 07f ; 
     [SerializeField] Text CountDownText ;    
    // Start is called before the first frame update
    void Start()
    {
      currentTime = startTime ;   
    }

    // Update is called once per frame
    void Update()
    {
         currentTime -= 1 * Time.deltaTime ; 
        CountDownText.text = currentTime.ToString("00:00") ;  
        if (currentTime < 0 ) 
        {
          currentTime =0 ;
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );

        } 
        else 
        if (currentTime < 0020)
        {
          CountDownText.color = Color.red ;
        }
        else 
        if (currentTime > 0020)
        {
          CountDownText.color = Color.white ;
        }
        
    }
}
