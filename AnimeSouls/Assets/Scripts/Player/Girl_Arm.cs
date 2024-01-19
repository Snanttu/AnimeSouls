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

    public void UpdateArmsSprites(Sprite[] sprites)
    {
        shoulder.sprite = sprites[0];
        bicep.sprite = sprites[1];
        forearm.sprite = sprites[2];
    }
}
