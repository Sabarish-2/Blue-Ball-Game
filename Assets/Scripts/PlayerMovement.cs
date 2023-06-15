using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D Controller;
   
    float horizontalmove = 0f;
    
    public float runspeed = 40f;
    
    bool jump = false;
    
    void Update()
    
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }



        horizontalmove = Input.GetAxisRaw("Horizontal") * runspeed;  
       
        if(Input.GetButtonDown("Jump"))      
        { 
            jump = true;
        }
    }
    
    void FixedUpdate()
    
    {
        //Moving the Character
        Controller.Move(horizontalmove * Time.fixedDeltaTime,false,jump);
        jump = false;

    }
    

}