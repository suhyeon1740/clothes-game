using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultButton : MonoBehaviour
{
    public Character character;
    string answerShirtName = "character_shirt1";

    public void ResultButtonClick() {
        if (GameManager.Instance.GetState() == 2) {
            return;
        }
        GameManager.Instance.ChangeState(2);
    }

    public void CheckAnswer()
    {
        // 옷을 안입었거나 정답과 다르면
        if (character.shirt.sprite == null ||
            !answerShirtName.Equals(character.shirt.sprite.name))
        {
            Debug.Log("셔츠가 틀렸습니다");
        }
    }
}
