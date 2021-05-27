using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public RectTransform rt;
    public void LeftButtonClick()
    {
        if (rt.localScale.x < 0)
        {
            rt.localScale = new Vector2(rt.localScale.x * -1f, rt.localScale.y);
        }
    }
    public void RightButtonClick()
    {
        if (rt.localScale.x > 0)
        {
            rt.localScale = new Vector2(rt.localScale.x * -1f, rt.localScale.y);
        }
    }
}
