using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : IComparable<BadGuy>
{
    public string name;
    public int power;

    public BadGuy(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }

    public int CompareTo(BadGuy other)
    {
        if(other == null)
        {
            return 1;
        }

        return power - other.power;
    }

}

public class SomeClass : MonoBehaviour
{
    private void Start()
    {
        List<BadGuy> badguys = new List<BadGuy>();

        badguys.Add(new BadGuy("pepito", 50));
        badguys.Add(new BadGuy("raulito", 100));
        badguys.Add(new BadGuy("alejandrito", 10));

        BadGuy tercero = badguys[2];

        int cantidad = badguys.Count;

        badguys.Insert(2,new BadGuy("nuevo tercero", 200));

        badguys.Sort();
        foreach (BadGuy guy in badguys)
        {
            print (guy.name + " " + guy.power + "\n");
        }

        badguys.Clear();

    }
}
