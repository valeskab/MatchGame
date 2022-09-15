using UnityEngine;
[CreateAssetMenu]
public class MyFloatData : ScriptableObject

// The data in scriptable objects can be shared in any scene
{
    public float value; // This line creates the float data asset

    public void SetValue(float num)
    {
        value = num;
    }

    public void UpdateValue(float num) //Helps interact with the scene
    {
        value += num;
    }
}
