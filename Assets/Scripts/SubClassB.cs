using System;
using UnityEngine;

namespace AG2163
{
    public class SubClassB : PolymorphismBaseClass
    {
        public override void ShowMessage()
        {
            base.ShowMessage(); 
            Debug.Log("And hello from SubClassB!");
        }
    }
}