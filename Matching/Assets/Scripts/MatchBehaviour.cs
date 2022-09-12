using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null)
            return;   // If the object is Null (if theres not an object there) its going to return meaning it's not gonna run the code below
            
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
    }
}
