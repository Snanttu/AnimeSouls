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

    [Header("Extra")]
    [SerializeField]
    private SpriteRenderer thigh_Behind;

    public void UpdateLegsSprites(Sprite[] sprites, Sprite thighBehind = null)
    {
        thigh.sprite = sprites[0];
        calf.sprite = sprites[1];
        foot.sprite = sprites[2];

        if (thigh_Behind != null && thighBehind != null) thigh_Behind.sprite = thighBehind;
    }
}
