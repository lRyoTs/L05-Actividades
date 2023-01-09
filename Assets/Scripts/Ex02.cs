using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex02 : MonoBehaviour
{
    public string username;
    public string password;
    // Start is called before the first frame update
    void Start()
    {
        if (Login(username, password))
        {
            Debug.Log($"You successfully login in");
        }
        else {
            Debug.Log($"The username or password is incorrect");
        }
    }

    private bool Login(string givenUser, string givenPass) {
        string username = "admin";
        string password = "abccba";

        if (givenUser == username && givenPass == password) {
            return true;
        }

        return false;
    }
}
