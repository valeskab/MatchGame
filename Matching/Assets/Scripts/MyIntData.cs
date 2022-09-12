using UnityEngine;

[CreateAssetMenu]
public class MyIntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int num)
    {
        value += num;
    }
}
