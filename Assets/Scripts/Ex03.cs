using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{
    public int counter = 0;
    // Start is called before the first frame update
    void Update()
    {
        if (Input. && counter<10) {
            IncreaseByOne()
            if (counter == 10) {
                Debug.Log($"GAME OVER")
            } 
        }
    }

   
    private void IncreaseByOne(){
        counter++;
    }
}
