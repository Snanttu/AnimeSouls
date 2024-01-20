using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_Leg : MonoBehaviour
{
    [Header("Legs")]
    [SerializeField]
    private SpriteRenderer thigh;
    [SerializeField]
    private SpriteRenderer calf;
    [SerializeField]
    private SpriteRenderer foot;

    [Header("Pants")]
    [SerializeField]
    private SpriteRenderer pants_thigh;
    [SerializeField]
    private SpriteRenderer pants_calf;
    [SerializeField]
    private SpriteRenderer pants_foot;

    [Header("Boots")]
    [SerializeField]
    private SpriteRenderer boots_calf;
    [SerializeField]
    private SpriteRenderer boots_calf_behind;
    [SerializeField]
    private SpriteRenderer boots_foot;

    [Header("Extra")]
    [SerializeField]
    private SpriteRenderer thigh_Behind;
    [SerializeField]
    private SpriteRenderer pants_Behind;

    [Header("Masks")]
    [SerializeField]
    private SpriteMask mask_thigh;
    [SerializeField]
    private SpriteMask mask_thigh_behind;
    [SerializeField]
    private SpriteMask mask_calf;
    [SerializeField]
    private SpriteMask mask_foot;
    [SerializeField]
    private SpriteMask mask_pants_calf;
    [SerializeField]
    private SpriteMask mask_pants_foot;

    public void UpdateLegsSprites(Sprite[] sprites, Sprite thighBehind = null)
    {
        thigh.sprite = sprites[0];
        calf.sprite = sprites[1];
        foot.sprite = sprites[2];

        if (thigh_Behind != null && thighBehind != null) thigh_Behind.sprite = thighBehind;
    }

    public void ChangePants(Sprite[] sprites, Sprite[] masks)
    {
        pants_thigh.sprite = sprites[0];
        mask_thigh.sprite = masks[0];

        pants_calf.sprite = sprites[1];
        mask_calf.sprite = masks[1];

        pants_foot.sprite = sprites[2];
        mask_foot.sprite = masks[2];

        if (pants_Behind != null)
        {
            pants_Behind.sprite = sprites[3];
            mask_thigh_behind.sprite = masks[0];
        }
    }

    public void ChangeBoots(Sprite[] sprites, Sprite[] masks)
    {
        boots_calf.sprite = sprites[0];
        mask_pants_calf.sprite = masks[0];

        boots_calf_behind.sprite = sprites[1];

        boots_foot.sprite = sprites[2];
        mask_pants_foot.sprite = masks[1];
    }
}
