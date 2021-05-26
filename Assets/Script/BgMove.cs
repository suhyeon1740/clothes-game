using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMove : MonoBehaviour
{
    public RectTransform rt; // public을 선언하면 인스펙터에서 확인/변경 가능
    public float speed = 200f;
    public bool isRightClick = false;
    public bool isLeftClick = false;
    public void RightButtonPress()
    {
        isRightClick = true;
    }
    public void RightButtonRelease()
    {
        isRightClick = false;
    }
    public void LeftButtonPress()
    {
        isLeftClick = true;
    }
    public void LeftButtonRelease()
    {
        isLeftClick = false;
    }
    private float maxX = -693;
    // 📖 Update: 매 프레임마다 불리는 함수
    // 키보드가 눌리는 걸 매 프레임마다 감시해야 하기 때문에 update에 코드 작성
    void Update()
    {
        // Input.GetKey: 키보드 입력이 들어오면 true 리턴
        if (isRightClick)
        {
            // 좌표를 직접 지정할 수는 없어 vector로 넣어야 함
            // 디바이스 성능에 따라 프레임이 다르기 때문에 deltaTime으로 모든 기기에 동일하게 해줌 
            float x = rt.anchoredPosition.x - (speed * Time.deltaTime);
            if (x < maxX)
            {
                x = maxX;
            }
            rt.anchoredPosition = new Vector2(x, rt.anchoredPosition.y);
        }
        if (isLeftClick)
        {
            float x = rt.anchoredPosition.x + (speed * Time.deltaTime);
            if (x > maxX * -1)
            {
                x = maxX * -1;
            }
            rt.anchoredPosition = new Vector2(x, rt.anchoredPosition.y);
        }
    }
}
