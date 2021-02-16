using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public string Add(string s1, string s2)
    {
        return s1 + s2;
    }
}

public class SomeOtherClass : MonoBehaviour
{
    private void Start() {
        SomeClass myClass = new SomeClass();

        myClass.Add(2,2);

        myClass.Add("Hola ","Mundo");

        Debug.Log("hola mundo");
    }
}
