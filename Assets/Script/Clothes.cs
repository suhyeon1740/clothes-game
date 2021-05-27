using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour
{
    public Character character;
    public Sprite clothesImage;
    public void ClickShirt() {
        character.ChangeShirt(clothesImage);
    }
}
