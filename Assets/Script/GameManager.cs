using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    // 게임매니저는 다른 여러 스크립트에서도 사용되기때문에 각 스크립트에 public으로 각각 선언하는 것보단
    // Singleton 패턴을 사용해서 접근 가능하도록 적용
    // static을 쓰면 씬이 바뀌더라도 메모리가 해제되지 않고 살아있음, 오브젝트를 끌어댜놓지 않아도 다른 곳에서 사용가능
    private static GameManager instance;

    // 외부에서 GameManager.Instance 를 호출하면
    // 아래 get 함수가 실행됨
    public static GameManager Instance
    {
        get
        {
            if (!instance)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
                if (!instance)
                {
                    Debug.Log("GameManager가 없음");
                }
            }
            return instance;
        }
    }

    // 0: 플레이전, 1: 플레이중, 2: 게임종료
    // TODO: enum으로 해야 관리가 편하기 때문에 quizGame 참고해서 변경 필요 
    public RectTransform background;
    public Character character;
    private int gameState = 0;
    public int GetState() {
        return gameState;
    }
    public void ChangeState(int change)
    {
        gameState = change;
        if (gameState == 2){
            background.DOAnchorPosX(693f,1); // 1초동안 693 위치로 이동
            character.TurnLeft();
        }
    }
}
