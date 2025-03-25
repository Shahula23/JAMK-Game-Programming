using System;
using UnityEngine;

namespace AG2163
{
    public class SubClassA : PolymorphismBaseClass
    {
        public override void ShowMessage()
        {
            Debug.Log("Hello from SubClassA!");
        }
    }
}
