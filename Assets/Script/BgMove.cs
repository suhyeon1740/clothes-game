using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMove : MonoBehaviour
{
    public RectTransform rt; // public을 선언하면 인스펙터에서 확인/변경 가능
    private float speed = 200f;
    // 📖 Update: 매 프레임마다 불리는 함수
    // 키보드가 눌리는 걸 매 프레임마다 감시해야 하기 때문에 update에 코드 작성
    void Update()
    {
        // Input.GetKey: 키보드 입력이 들어오면 true 리턴
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 좌표를 직접 지정할 수는 없어 vector로 넣어야 함
            // 디바이스 성능에 따라 프레임이 다르기 때문에 deltaTime으로 모든 기기에 동일하게 해줌 
            rt.anchoredPosition = new Vector2(rt.anchoredPosition.x - (speed * Time.deltaTime), rt.anchoredPosition.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rt.anchoredPosition = new Vector2(rt.anchoredPosition.x + (speed * Time.deltaTime), rt.anchoredPosition.y);   
            // TODO: 첫 시작 땐 우측으로 이동되면 안됨 (빈 배경이 나옴)
        }
    }
}
