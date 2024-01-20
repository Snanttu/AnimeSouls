using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_Hand : MonoBehaviour
{
    [Header("Hand")]
    [SerializeField]
    private SpriteRenderer fist;
    [SerializeField]
    private SpriteRenderer palm;
    [SerializeField]
    private SpriteRenderer fingers;

    [Header("Gloves")]
    [SerializeField]
    private SpriteRenderer gloves_fist;
    [SerializeField]
    private SpriteRenderer gloves_palm;
    [SerializeField]
    private SpriteRenderer gloves_fingers;

    [Header("Masks")]
    [SerializeField]
    private SpriteMask mask_fist;
    [SerializeField]
    private SpriteMask mask_palm;
    [SerializeField]
    private SpriteMask mask_fingers;

    public void UpdateHandSprites(Sprite[] sprites)
    {
        fist.sprite = sprites[0];
        palm.sprite = sprites[1];
        fingers.sprite = sprites[2];
    }

    public void ChangeGloves(Sprite[] sprites, Sprite[] masks)
    {
        gloves_fist.sprite = sprites[2];
        mask_fist.sprite = masks[1];

        gloves_palm.sprite = sprites[3];
        mask_palm.sprite = masks[2];

        gloves_fingers.sprite = sprites[4];
        mask_fingers.sprite = masks[3];
    }
}
