using UnityEngine;

public class EncapsulationScript2 : MonoBehaviour
{
    private int someValue = 5;

    public void ModifyValue(int amount)
    {
        someValue += amount;
    }

    public int GetValue()
    {
        return someValue;
    }
}
