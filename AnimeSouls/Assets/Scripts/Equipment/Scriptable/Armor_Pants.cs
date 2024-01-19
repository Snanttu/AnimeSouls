using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor_Pants", menuName = "ScriptableObjects/Armor_Pants", order = 2)]
public class Armor_Pants : Equipment_Base
{
    [SerializeField]
    private Sprite[] _pantsSprites;

    [Header("Front")]
    [SerializeField]
    private Sprite front_bottom;
    [SerializeField]
    private Sprite front_thigh;
    [SerializeField]
    private Sprite front_calf;

    [Header("Side")]
    [SerializeField]
    private Sprite side_bottom;
    [SerializeField]
    private Sprite side_thigh_F;
    [SerializeField]
    private Sprite side_thigh_B;
    [SerializeField]
    private Sprite side_behind;
    [SerializeField]
    private Sprite side_calf;

    [Header("Back")]
    [SerializeField]
    private Sprite back_bottom;
    [SerializeField]
    private Sprite back_bottom_behind;
    [SerializeField]
    private Sprite back_thigh;
    [SerializeField]
    private Sprite back_calf;

    [Header("Feet")]
    [SerializeField]
    private Sprite foot_front;
    [SerializeField]
    private Sprite foot_back;
    [SerializeField]
    private Sprite foot_side_F;
    [SerializeField]
    private Sprite foot_side_B;

    [SerializeField]
    private Sprite[] _masks;

    public Sprite GetSprite(int _index)
    {
        return _pantsSprites[_index];
    }
    public Sprite GetMask(int _index)
    {
        return _masks[_index];
    }
}
