using UnityEngine;

[CreateAssetMenu]

public class MyInstancer : ScriptableObject
{
    public GameObject prefab;
    
    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity); //its gonna keep its rotate values at 0
    }
}
