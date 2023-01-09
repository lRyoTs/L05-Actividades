using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{
    public int counter = 0;  
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && counter<10) {
            IncreaseByOne(); //Increase by one
            Debug.Log($"Counter: {counter}");
            if (counter == 10) {
                Debug.Log($"GAME OVER"); //Display game over message
            } 
        }
    }
    
    //Function that increase the counter by one
    private void IncreaseByOne(){
        counter++;
    }
}
