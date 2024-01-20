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
        if (bodyPart == BodyPart.legFront) return new Sprite[] { front_calf, front_calf_behind, foot_front };
        else return new Sprite[] { side_calf, side_calf_behind, foot_side_B };
    }

    public Sprite[] FrontMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.legFront) return new Sprite[] { mask_calf_front, mask_foot_front };
        else return new Sprite[] { mask_calf_side, mask_foot_side };
    }

    public Sprite[] SideSprites(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.legFront) return new Sprite[] { side_calf, side_calf_behind, foot_side_F };
        else return new Sprite[] { side_calf, side_calf_behind, foot_side_B };
    }

    public Sprite[] SideMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.legFront) return new Sprite[] { mask_calf_side, mask_foot_side };
        else return new Sprite[] { mask_calf_side, mask_foot_side };
    }

    public Sprite[] BackSprites(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.legFront) return new Sprite[] { side_calf, side_calf_behind, foot_side_F };
        else return new Sprite[] { back_calf, back_calf_behind, foot_back };
    }

    public Sprite[] BackMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.legFront) return new Sprite[] { mask_calf_side, mask_foot_side };
        else return new Sprite[] { mask_calf_side, mask_foot_side };
    }
}
