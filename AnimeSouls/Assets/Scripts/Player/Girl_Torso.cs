using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_Torso : MonoBehaviour
{
    [Header("Torso")]
    [SerializeField]
    private SpriteRenderer bottom;
    [SerializeField]
    private SpriteRenderer chest;
    [SerializeField]
    private SpriteRenderer neck;

    [Header("Extra")]
    [SerializeField]
    private SpriteRenderer bottom_behind;
    [SerializeField]
    private SpriteRenderer chest_behind;

    public void UpdateTorsoSprites(Sprite[] sprites, Sprite bottomBehind = null, Sprite chectBehind = null)
    {
        bottom.sprite = sprites[0];
        chest.sprite = sprites[1];
        neck.sprite = sprites[2];

        if (bottom_behind != null && bottomBehind != null) bottom_behind.sprite = bottomBehind;
        if (chest_behind != null && chectBehind != null) chest_behind.sprite = chectBehind;
    }
}