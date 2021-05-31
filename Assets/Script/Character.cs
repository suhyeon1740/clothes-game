using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Image사용을 위해서는 UnityEngine.UI를 사용해야함

public class Character : MonoBehaviour
{
    public RectTransform rt;
    public Image shirt;

    public void ChangeShirt(Sprite image)
    {
        shirt.enabled = true; // 처음에 흰 이미지때문에 enabled 해제해준거 다시 적용
        shirt.sprite = image;
        shirt.SetNativeSize();
    }
    public void LeftButtonClick()
    {
        // if (GameManager.Instance.GetState() == 2)
        // {   // 게임이 종료 후 버튼 클릭 막기
        //     return;
        // }
        if (rt.localScale.x < 0)
        {
            rt.localScale = new Vector2(rt.localScale.x * -1f, rt.localScale.y);
        }
    }
    public void TurnLeft() {
        if (rt.localScale.x < 0)
        {
            rt.localScale = new Vector2(rt.localScale.x * -1f, rt.localScale.y);
        }
    }
    public void RightButtonClick()
    {
        if (GameManager.Instance.GetState() == 2)
        {   // 게임이 종료 후 버튼 클릭 막기
            return;
        }
        if (rt.localScale.x > 0)
        {
            rt.localScale = new Vector2(rt.localScale.x * -1f, rt.localScale.y);
        }
    }
}
