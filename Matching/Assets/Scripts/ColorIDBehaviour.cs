using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    //Inherits from the IDContainerBehaviour
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
