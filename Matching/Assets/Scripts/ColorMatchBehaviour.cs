using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehaviour : MatchBehaviour
{
    //Inherits from the MatchBehaviour
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;
    }
}
