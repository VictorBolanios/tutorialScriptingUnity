using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass
{
    public T GenericMethod<T>(T param) where T : IEnumerable
    {
        return param;
    }
}

public class GenericClass<T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}

public class GenericClassExample : MonoBehaviour
{
    void Start()
    {
        GenericClass<string> myClass = new GenericClass<string>();

        myClass.UpdateItem("Hola Mundo");
    }
}

public class SomeOtherClass : MonoBehaviour
{
    private void Start() {
        SomeClass myClass = new SomeClass();

        myClass.GenericMethod<int>(5);
    }
}
