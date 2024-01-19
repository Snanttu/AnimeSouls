using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor_Boots", menuName = "ScriptableObjects/Armor_Boots", order = 4)]
public class Armor_Boots : Equipment_Base
{
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

    [Header("Masks")]
    [SerializeField]
    private Sprite mask_calf_front;
    [SerializeField]
    private Sprite mask_calf_back;
    [SerializeField]
    private Sprite mask_calf_side;
    [SerializeField]
    private Sprite mask_foot_front;
    [SerializeField]
    private Sprite mask_foot_side;

}
