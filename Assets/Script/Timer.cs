using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeLable;
    private int time = 30;

    // start: 오브젝트 생성 후 처음 한번 자동으로 실행되는 함수
    private void Start() {
        StartCoroutine(DoTime());
    }
    private IEnumerator DoTime()
    {
        yield return new WaitForSeconds(1.0f); // 1초 대기 후 아래 코드 실행
        time--;
        timeLable.text = time.ToString();
        if (time > 0) // 시간 예외처리
        {
            StartCoroutine(DoTime());
        } else {
            GameManager.Instance.ChangeState(2); // 게임종료 상태로 변경
        }

    }
}
