using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor_Shirt", menuName = "ScriptableObjects/Armor_Shirt", order = 1)]
public class Armor_Shirt : Equipment_Base
{  
    [SerializeField]
    private Sprite[] _shirtSprites;
    [SerializeField]
    private Sprite[] _skirtSprites;
    [SerializeField]
    private Sprite[] _shoulderSprites;

    [Header("Front")]
    [SerializeField]
    private Sprite front_bottom;
    [SerializeField]
    private Sprite front_chest;
    [SerializeField]
    private Sprite front_neck;
    [SerializeField]
    private Sprite front_skirt_L;
    [SerializeField]
    private Sprite front_skirt_M;
    [SerializeField]
    private Sprite front_skirt_R;

    [Header("Side")]
    [SerializeField]
    private Sprite side_bottom;
    [SerializeField]
    private Sprite side_chest;
    [SerializeField]
    private Sprite side_neck;
    [SerializeField]
    private Sprite side_skirt_L;
    [SerializeField]
    private Sprite side_skirt_M;
    [SerializeField]
    private Sprite side_skirt_R;

    [Header("Back")]
    [SerializeField]
    private Sprite back_bottom;
    [SerializeField]
    private Sprite back_chest;
    [SerializeField]
    private Sprite back_neck;
    [SerializeField]
    private Sprite back_chest_behind;
    [SerializeField]
    private Sprite back_bottom_behind;
    [SerializeField]
    private Sprite back_skirt_L;
    [SerializeField]
    private Sprite back_skirt_M;
    [SerializeField]
    private Sprite back_skirt_R;

    [Header("Masks")]
    [SerializeField]
    private Sprite[] _masks;

    public Sprite GetChestSprite (int _index)
    {
        return _shirtSprites[_index];
    }
    public Sprite GetMask(int _index)
    {
        return _masks[_index];
    }

    public Sprite GetSkirtSprite(int _index)
    {
        return _skirtSprites[_index];
    }

    public Sprite GetShoulderSprite(int _index)
    {
        return _shoulderSprites[_index];
    }
}