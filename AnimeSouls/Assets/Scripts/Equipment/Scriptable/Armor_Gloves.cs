using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor_Gloves", menuName = "ScriptableObjects/Armor_Gloves", order = 3)]
public class Armor_Gloves : Equipment_Base
{
    [SerializeField]
    private Sprite forearm_behind;

    [Header("Front_R")]
    [SerializeField]
    private Sprite front_forearm_R;
    [SerializeField]
    private Sprite front_fist_R;

    [Header("Front_L")]
    [SerializeField]
    private Sprite front_forearm_L;
    [SerializeField]
    private Sprite front_fist_L;

    [Header("Back_R")]
    [SerializeField]
    private Sprite back_forearm_R;
    [SerializeField]
    private Sprite back_palm_R;
    [SerializeField]
    private Sprite back_fingers_R;

    [Header("Back_L")]
    [SerializeField]
    private Sprite back_forearm_L;
    [SerializeField]
    private Sprite back_palm_L;
    [SerializeField]
    private Sprite back_fingers_L;

    [Header("Masks")]
    [SerializeField]
    private Sprite mask_forearm_front;
    [SerializeField]
    private Sprite mask_forearm_back;
    [SerializeField]
    private Sprite mask_fist;
    [SerializeField]
    private Sprite mask_palm;
    [SerializeField]
    private Sprite mask_fingers;

}
