using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor_Boots", menuName = "ScriptableObjects/Armor_Boots", order = 4)]
public class Armor_Boots : Equipment_Base
{
    [SerializeField]
    private Sprite[] _bootsSprites;

    [Header("Front")]
    [SerializeField]
    private Sprite front_calf;
    [SerializeField]
    private Sprite front_calf_behind;

    [Header("Side")]
    [SerializeField]
    private Sprite side_calf;
    [SerializeField]
    private Sprite side_calf_behind;

    [Header("Back")]
    [SerializeField]
    private Sprite back_calf;
    [SerializeField]
    private Sprite back_calf_behind;

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
        return _bootsSprites[_index];
    }
    public Sprite GetMask(int _index)
    {
        return _masks[_index];
    }
}
