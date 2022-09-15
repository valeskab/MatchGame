using UnityEngine;

[CreateAssetMenu]
public class MyIntData : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }
}
