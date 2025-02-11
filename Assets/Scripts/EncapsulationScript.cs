using UnityEngine;

public class EncapsulationScript : MonoBehaviour
{
    public EncapsulationScript2 helper;

    void Start()
    {
        helper.ModifyValue(10);

        Debug.Log("Modified Value: " + helper.GetValue());
    }
}
