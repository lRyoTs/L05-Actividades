using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{
    public int [] number = { 10, -13, -100, 101, 7 };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"First element {number[0]}");
        Debug.Log($"Second element {number[2]}");
        Debug.Log($"Fifth element {number[4]}");
    }

}
