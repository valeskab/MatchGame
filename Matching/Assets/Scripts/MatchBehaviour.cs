using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<IDContainerBehaviour>().idObj;
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
    }
}
