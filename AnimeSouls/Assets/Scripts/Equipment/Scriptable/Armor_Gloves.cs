using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor_Gloves", menuName = "ScriptableObjects/Armor_Gloves", order = 3)]
public class Armor_Gloves : Equipment_Base
{
    [SerializeField]
    private Sprite forearm_behind;

    [Header("Forearm")]
    [SerializeField]
    private Sprite front_forearm_L;
    [SerializeField]
    private Sprite front_forearm_R;
    [SerializeField]
    private Sprite back_forearm_L;
    [SerializeField]
    private Sprite back_forearm_R;

    [Header("Hand")]
    [SerializeField]
    private Sprite fist_L;
    [SerializeField]
    private Sprite fist_R;
    [SerializeField]
    private Sprite palm_L;
    [SerializeField]
    private Sprite palm_R;
    [SerializeField]
    private Sprite fingers_L;
    [SerializeField]
    private Sprite fingers_R;

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
        if (bodyPart == BodyPart.armFront) return new Sprite[] { front_forearm_L, forearm_behind, fist_L, palm_L, fingers_L };
        else return new Sprite[] { back_forearm_R, forearm_behind, fist_R, palm_R, fingers_R };
    }

    public Sprite[] FrontMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.armFront) return new Sprite[] { mask_forearm_front, mask_fist, mask_palm, mask_fingers };
        else return new Sprite[] { mask_forearm_back, mask_fist, mask_palm, mask_fingers };
    }

    public Sprite[] SideSprites(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.armFront) return new Sprite[] { front_forearm_R, forearm_behind, fist_R, palm_R, fingers_R };
        else return new Sprite[] { back_forearm_R, forearm_behind, fist_R, palm_R, fingers_R };
    }

    public Sprite[] SideMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.armFront) return new Sprite[] { mask_forearm_front, mask_fist, mask_palm, mask_fingers };
        else return new Sprite[] { mask_forearm_back, mask_fist, mask_palm, mask_fingers };
    }

    public Sprite[] BackSprites(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.armFront) return new Sprite[] { front_forearm_R, forearm_behind, fist_R, palm_R, fingers_R };
        else return new Sprite[] { back_forearm_L, forearm_behind, fist_L, palm_L, fingers_L };
    }

    public Sprite[] BackMasks(BodyPart bodyPart)
    {
        if (bodyPart == BodyPart.armFront) return new Sprite[] { mask_forearm_front, mask_fist, mask_palm, mask_fingers };
        else return new Sprite[] { mask_forearm_back, mask_fist, mask_palm, mask_fingers };
    }
}
