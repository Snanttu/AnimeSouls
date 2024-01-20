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
    private Sprite front_skirt_L;
    [SerializeField]
    private Sprite front_skirt_M;
    [SerializeField]
    private Sprite front_skirt_R;
    [SerializeField]
    private Sprite front_thigh;
    [SerializeField]
    private Sprite front_calf;

    [Header("Side")]
    [SerializeField]
    private Sprite side_bottom;
    [SerializeField]
    private Sprite side_skirt_L;
    [SerializeField]
    private Sprite side_skirt_M;
    [SerializeField]
    private Sprite side_skirt_R;
    [SerializeField]
    private Sprite side_thigh_F;
    [SerializeField]
    private Sprite side_thigh_B;
    [SerializeField]
    private Sprite side_calf;
    [SerializeField]
    private Sprite side_thigh_behind;

    [Header("Back")]
    [SerializeField]
    private Sprite back_bottom;
    [SerializeField]
    private Sprite back_bottom_behind;
    [SerializeField]
    private Sprite back_skirt_L;
    [SerializeField]
    private Sprite back_skirt_M;
    [SerializeField]
    private Sprite back_skirt_R;
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

    public Sprite[] GetSprites(BodyPart bodyPart, BodyOrientation orientation)
    {
        if (orientation == BodyOrientation.front) return FrontSprites(bodyPart);
        else if (orientation == BodyOrientation.side) return SideSprites(bodyPart);
        else return BackSprites(bodyPart);
    }

    public Sprite[] GetMasks(BodyPart bodyPart, BodyOrientation orientation)
    {
        if (orientation == BodyOrientation.front) return FrontMasks(bodyPart);
        else if (orientation == BodyOrientation.side) return SideMasks(bodyPart);
        else return BackMasks(bodyPart);
    }

    public Sprite[] FrontSprites(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { front_bottom, front_skirt_L, front_skirt_M, front_skirt_R };
        else if (bodyPart == BodyPart.legFront) return new Sprite[] { front_thigh, front_calf, foot_front };
        else return new Sprite[] { side_thigh_B, side_calf, foot_side_B };
    }

    public Sprite[] FrontMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { mask_bottom_front };
        else if (bodyPart == BodyPart.legFront) return new Sprite[] { mask_thigh, mask_calf, mask_foot };
        else return new Sprite[] { mask_thigh, mask_calf, mask_foot };
    }

    public Sprite[] SideSprites(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { side_bottom, side_skirt_L, side_skirt_M, side_skirt_R };
        else if (bodyPart == BodyPart.legFront) return new Sprite[] { side_thigh_F, side_calf, foot_side_F, side_thigh_behind };
        else return new Sprite[] { side_thigh_B, side_calf, foot_side_B };
    }

    public Sprite[] SideMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { mask_bottom_side };
        else if (bodyPart == BodyPart.legFront) return new Sprite[] { mask_thigh, mask_calf, mask_foot };
        else return new Sprite[] { mask_thigh, mask_calf, mask_foot };
    }

    public Sprite[] BackSprites(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { back_bottom, back_skirt_L, back_skirt_M, back_skirt_R, back_bottom_behind };
        else if (bodyPart == BodyPart.legFront) return new Sprite[] { side_thigh_B, side_calf, foot_side_F };
        else return new Sprite[] { back_thigh, back_calf, foot_back };
    }

    public Sprite[] BackMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { mask_bottom_front };
        else if (bodyPart == BodyPart.legFront) return new Sprite[] { mask_thigh, mask_calf, mask_foot };
        else return new Sprite[] { mask_thigh, mask_calf, mask_foot };
    }
}
