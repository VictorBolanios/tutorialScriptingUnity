using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SampleNamespace;

public class SomeOtherClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          SampleNamespace.SomeClass myClass = new SampleNamespace.SomeClass();
          SampleNamespace.SomeOtherClass2 mySomeOtherClass = new SampleNamespace.SomeOtherClass2();
    }
}

namespace SampleNamespace
{
    public class SomeOtherClass2 : MonoBehaviour
    {
        private void Start() {
            SomeClass myClass = new SomeClass();
        }
    }
}
