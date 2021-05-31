using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour
{
    public Character character;
    public Sprite clothesImage;
    public void ClickShirt() {
        if (GameManager.Instance.GetState() == 2)
        {   // 게임이 종료 후 버튼 클릭 막기
            return;
        }
        character.ChangeShirt(clothesImage);
    }
}
