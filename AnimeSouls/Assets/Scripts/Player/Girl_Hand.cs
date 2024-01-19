using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_Hand : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer fist_front;
    [SerializeField]
    private SpriteRenderer fist_back;
    [SerializeField]
    private SpriteRenderer fist_fingers;

    public void UpdateHandSprites(Sprite[] sprites)
    {
        fist_front.sprite = sprites[0];
        fist_back.sprite = sprites[1];
        fist_fingers.sprite = sprites[2];
    }
}
