using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_Head : MonoBehaviour
{
    [Header("Face")]
    [SerializeField]
    private SpriteRenderer head;
    [SerializeField]
    private SpriteRenderer mouth;
    [SerializeField]
    private SpriteRenderer eyebrow_R;
    [SerializeField]
    private SpriteRenderer eyebrow_L;

    [Header("Eyes")]
    [SerializeField]
    private SpriteRenderer eyes;
    [SerializeField]
    private SpriteRenderer eyes_white;
    [SerializeField]
    private SpriteRenderer eyes_area;
    [SerializeField]
    private SpriteRenderer pupil_R;
    [SerializeField]
    private SpriteRenderer pupil_L;

    [Header("Hair")]
    [SerializeField]
    private SpriteRenderer hair;
    [SerializeField]
    private SpriteRenderer hair_behind;
    [SerializeField]
    private SpriteRenderer hair_ponytail;

    public void UpdateHeadSprite(Sprite headSprite)
    {
        head.sprite = headSprite;
    }

    public void UpdateEyebrowSprites(Sprite[] sprites)
    {
        eyebrow_R.sprite = sprites[0];
        if (eyebrow_L != null) eyebrow_L.sprite = sprites[1];
    }

    public void UpdatePupilSprites(Sprite[] sprites)
    {
        pupil_R.sprite = sprites[0];
        if (pupil_L != null) pupil_L.sprite = sprites[1];
    }

    public void UpdateEyeSprites(Sprite[] sprites)
    {
        eyes.sprite = sprites[0];
        eyes_white.sprite = sprites[0];
        eyes_area.sprite = sprites[0];
    }
}
