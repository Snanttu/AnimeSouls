using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor_Shirt", menuName = "ScriptableObjects/Armor_Shirt", order = 1)]
public class Armor_Shirt : Equipment_Base
{
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
    [SerializeField]
    private Sprite front_shoulder_front;
    [SerializeField]
    private Sprite front_shoulder_back;
    [SerializeField]
    private Sprite front_bicep_front;
    [SerializeField]
    private Sprite front_bicep_back;
    [SerializeField]
    private Sprite front_forearm_front;
    [SerializeField]
    private Sprite front_forearm_back;

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
    [SerializeField]
    private Sprite side_shoulder_front;
    [SerializeField]
    private Sprite side_shoulder_back;
    [SerializeField]
    private Sprite side_bicep_front;
    [SerializeField]
    private Sprite side_bicep_back;
    [SerializeField]
    private Sprite side_forearm_front;
    [SerializeField]
    private Sprite side_forearm_back;

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
    private Sprite back_skirt_L;
    [SerializeField]
    private Sprite back_skirt_M;
    [SerializeField]
    private Sprite back_skirt_R;
    [SerializeField]
    private Sprite back_shoulder_front;
    [SerializeField]
    private Sprite back_shoulder_back;
    [SerializeField]
    private Sprite back_bicep_front;
    [SerializeField]
    private Sprite back_bicep_back;
    [SerializeField]
    private Sprite back_forearm_front;
    [SerializeField]
    private Sprite back_forearm_back;

    [Header("Masks")]
    [SerializeField]
    private Sprite mask_front_chest;
    [SerializeField]
    private Sprite mask_front_neck;
    [SerializeField]
    private Sprite mask_side_chest;
    [SerializeField]
    private Sprite mask_side_neck;
    [SerializeField]
    private Sprite mask_back_chest;
    [SerializeField]
    private Sprite mask_back_neck;
    [SerializeField]
    private Sprite mask_bicep_front;
    [SerializeField]
    private Sprite mask_bicep_back;
    [SerializeField]
    private Sprite mask_forearm_front;
    [SerializeField]
    private Sprite mask_forearm_back;

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
        if (bodyPart == BodyPart.torso) return new Sprite[] { front_bottom, front_chest, front_neck, front_skirt_L, front_skirt_M, front_skirt_R };
        else if (bodyPart == BodyPart.armFront) return new Sprite[] { front_shoulder_front, front_bicep_front, front_forearm_front };
        else return new Sprite[] { front_shoulder_back, front_bicep_back, front_forearm_back };
    }

    public Sprite[] FrontMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { mask_front_chest, mask_front_neck };
        else if (bodyPart == BodyPart.armFront) return new Sprite[] { mask_bicep_front, mask_forearm_front };
        else return new Sprite[] { mask_bicep_back, mask_forearm_back };
    }

    public Sprite[] SideSprites(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { side_bottom, side_chest, side_neck, side_skirt_L, side_skirt_M, side_skirt_R };
        else if (bodyPart == BodyPart.armFront) return new Sprite[] { side_shoulder_front, side_bicep_front, side_forearm_front };
        else return new Sprite[] { side_shoulder_back, side_bicep_back, side_forearm_back };
    }

    public Sprite[] SideMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { mask_side_chest, mask_side_neck };
        else if (bodyPart == BodyPart.armFront) return new Sprite[] { mask_bicep_front, mask_forearm_front };
        else return new Sprite[] { mask_bicep_back, mask_forearm_back };
    }

    public Sprite[] BackSprites(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { back_bottom, back_chest, back_neck, back_skirt_L, back_skirt_M, back_skirt_R, back_chest_behind };
        else if (bodyPart == BodyPart.armFront) return new Sprite[] { back_shoulder_front, back_bicep_front, back_forearm_front };
        else return new Sprite[] { back_shoulder_back, back_bicep_back, back_forearm_back };
    }

    public Sprite[] BackMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.torso) return new Sprite[] { mask_back_chest, mask_back_neck };
        else if (bodyPart == BodyPart.armFront) return new Sprite[] { mask_bicep_front, mask_forearm_front };
        else return new Sprite[] { mask_bicep_back, mask_forearm_back };
    }
}