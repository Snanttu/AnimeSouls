using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_Arm : MonoBehaviour
{
    [Header("Arms")]
    [SerializeField]
    private SpriteRenderer shoulder;
    [SerializeField]
    private SpriteRenderer bicep;
    [SerializeField]
    private SpriteRenderer forearm;

    public void UpdateArmsSprites(Sprite[] sprites)
    {
        shoulder.sprite = sprites[0];
        bicep.sprite = sprites[1];
        forearm.sprite = sprites[2];
    }
}
