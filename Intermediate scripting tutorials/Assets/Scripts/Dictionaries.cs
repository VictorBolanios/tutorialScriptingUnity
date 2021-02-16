using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        Dictionary<string,BadGuy> badguys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("pepito", 50);
        BadGuy bg2 = new BadGuy("raulito", 100);

        badguys.Add("gangster",bg1);
        badguys.Add("mutant",bg2);

        BadGuy magneto = badguys["mutant"];
        BadGuy temp = null;

        if(badguys.TryGetValue("birds", out temp))
        {
            //success
            magneto = badguys["birds"];
        }
        else
        {
            //failure
            //mensaje de que no existe la clave
        }

    }
}
