using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 0: 플레이전, 1: 플레이중, 2: 게임종료
    // TODO: enum으로 해야 관리가 편하기 때문에 quizGame 참고해서 변경 필요 
    public int GameState = 0;

    // 게임매니저는 다른 여러 스크립트에서도 사용되기때문에 각 스크립트에 public으로 각각 선언하는 것보단
    // Singleton 패턴을 사용해서 접근 가능하도록 적용
    private static GameManager instance; // TODO: static이 뭐더라...

    // 외부에서 GameManager.instance 를 호출하면
    // 아래 get 함수가 실행됨
    public static GameManager instance {
        get {
            if(!instance) {
                instance = GameObject.FindObjectOfType<GameManager>();
                if (!instance) {
                    Debug.Log("GameManager가 없음");
                }
            }
            return instance;
        }
    }
}
