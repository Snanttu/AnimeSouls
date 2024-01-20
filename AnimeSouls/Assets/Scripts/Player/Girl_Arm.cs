using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_Arm : MonoBehaviour
{
    [Header("Arm")]
    [SerializeField]
    private SpriteRenderer shoulder;
    [SerializeField]
    private SpriteRenderer bicep;
    [SerializeField]
    private SpriteRenderer forearm;

    [Header("Shirt")]
    [SerializeField]
    private SpriteRenderer shirt_shoulder;
    [SerializeField]
    private SpriteRenderer shirt_bicep;
    [SerializeField]
    private SpriteRenderer shirt_forearm;

    [Header("Gloves")]
    [SerializeField]
    private SpriteRenderer gloves_forearm;
    [SerializeField]
    private SpriteRenderer gloves_forearm_behind;

    [Header("Masks")]
    [SerializeField]
    private SpriteMask mask_bicep;
    [SerializeField]
    private SpriteMask mask_forearm;
    [SerializeField]
    private SpriteMask mask_shirt_forearm;

    public void UpdateArmsSprites(Sprite[] sprites)
    {
        shoulder.sprite = sprites[0];
        bicep.sprite = sprites[1];
        forearm.sprite = sprites[2];
    }

    public void ChangeShirt(Sprite[] sprites, Sprite[] masks)
    {
        shirt_shoulder.sprite = sprites[0];

        shirt_bicep.sprite = sprites[1];
        mask_bicep.sprite = masks[0];

        shirt_forearm.sprite = sprites[2];
        mask_forearm.sprite = masks[1];
    }

    public void ChangeGloves(Sprite[] sprites, Sprite[] masks)
    {
        gloves_forearm.sprite = sprites[0];
        mask_shirt_forearm.sprite = masks[0];

        gloves_forearm_behind.sprite = sprites[1];
    }
}
