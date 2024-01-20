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

    [Header("Shirt")]
    [SerializeField]
    private SpriteRenderer shirt_bottom;
    [SerializeField]
    private SpriteRenderer shirt_chest;
    [SerializeField]
    private SpriteRenderer shirt_neck;
    [SerializeField]
    private SpriteRenderer shirt_skirt_L;
    [SerializeField]
    private SpriteRenderer shirt_skirt_M;
    [SerializeField]
    private SpriteRenderer shirt_skirt_R;

    [Header("Pants")]
    [SerializeField]
    private SpriteRenderer pants_bottom;
    [SerializeField]
    private SpriteRenderer pants_skirt_L;
    [SerializeField]
    private SpriteRenderer pants_skirt_M;
    [SerializeField]
    private SpriteRenderer pants_skirt_R;

    [Header("Extra")]
    [SerializeField]
    private SpriteRenderer chest_behind;
    [SerializeField]
    private SpriteRenderer shirt_chest_behind;
    [SerializeField]
    private SpriteRenderer bottom_behind;
    [SerializeField]
    private SpriteRenderer shirt_bottom_behind;
    [SerializeField]
    private SpriteRenderer pants_bottom_behind;

    [Header("Masks")]
    [SerializeField]
    private SpriteMask mask_bottom;
    [SerializeField]
    private SpriteMask mask_chest;
    [SerializeField]
    private SpriteMask mask_neck;
    [SerializeField]
    private SpriteMask mask_bottom_behind;
    [SerializeField]
    private SpriteMask mask_chest_behind;

    public void UpdateTorsoSprites(Sprite[] sprites, Sprite bottomBehind = null, Sprite chectBehind = null)
    {
        bottom.sprite = sprites[0];
        chest.sprite = sprites[1];
        neck.sprite = sprites[2];

        if (bottom_behind != null && bottomBehind != null) bottom_behind.sprite = bottomBehind;
        if (chest_behind != null && chectBehind != null) chest_behind.sprite = chectBehind;
    }

    public void ChangeShirt(Sprite[] sprites, Sprite[] masks)
    {
        shirt_bottom.sprite = sprites[0];

        shirt_chest.sprite = sprites[1];
        mask_chest.sprite = masks[0];

        shirt_neck.sprite = sprites[2];
        mask_neck.sprite = masks[1];

        shirt_skirt_L.sprite = sprites[3];
        shirt_skirt_M.sprite = sprites[4];
        shirt_skirt_R.sprite = sprites[5];

        if (chest_behind != null)
        {
            shirt_chest_behind.sprite = sprites[6];
            mask_chest_behind.sprite = masks[0];
        }
    }

    public void ChangePants(Sprite[] sprites, Sprite[] masks)
    {
        pants_bottom.sprite = sprites[0];
        mask_bottom.sprite = masks[0];

        pants_skirt_L.sprite = sprites[1];
        pants_skirt_M.sprite = sprites[2];
        pants_skirt_R.sprite = sprites[3];

        if (bottom_behind != null)
        {
            pants_bottom_behind.sprite = sprites[4];
            mask_bottom_behind.sprite = masks[0];
        }
    }
}
