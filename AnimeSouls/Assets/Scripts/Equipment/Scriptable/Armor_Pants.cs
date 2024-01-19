using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor_Pants", menuName = "ScriptableObjects/Armor_Pants", order = 2)]
public class Armor_Pants : Equipment_Base
{
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

    [Header("Mask")]
    [SerializeField]
    private Sprite mask_bottom_front;
    [SerializeField]
    private Sprite mask_bottom_side;
    [SerializeField]
    private Sprite mask_thigh;
    [SerializeField]
    private Sprite mask_calf;
    [SerializeField]
    private Sprite mask_foot;

}
