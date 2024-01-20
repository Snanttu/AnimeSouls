using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BodyOrientation
{
    front,
    side,
    back
}

public enum BodyPart
{
    head,
    torso,
    armFront,
    armBack,
    handFront,
    handBack,
    legFront,
    legBack
}

public class Girl_Body : MonoBehaviour
{
    [SerializeField]
    private BodyOrientation orientation;

    [Header("Parts")]
    [SerializeField]
    private Girl_Head head;
    [SerializeField]
    private Girl_Torso torso;
    [SerializeField]
    private Girl_Arm arm_front;
    [SerializeField]
    private Girl_Arm arm_back;
    [SerializeField]
    private Girl_Hand hand_front;
    [SerializeField]
    private Girl_Hand hand_back;
    [SerializeField]
    private Girl_Leg leg_front;
    [SerializeField]
    private Girl_Leg leg_back;

    public void ChangeShirt(Armor_Shirt shirt)
    {
        torso.ChangeShirt(shirt.GetSprites(BodyPart.torso, orientation), shirt.GetMasks(BodyPart.torso, orientation));
        arm_front.ChangeShirt(shirt.GetSprites(BodyPart.armFront, orientation), shirt.GetMasks(BodyPart.armFront, orientation));
        arm_back.ChangeShirt(shirt.GetSprites(BodyPart.armBack, orientation), shirt.GetMasks(BodyPart.armBack, orientation));
    }

    public void ChangeGloves(Armor_Gloves gloves)
    {
        arm_front.ChangeGloves(gloves.GetSprites(BodyPart.armFront, orientation), gloves.GetMasks(BodyPart.armFront, orientation));
        arm_back.ChangeGloves(gloves.GetSprites(BodyPart.armBack, orientation), gloves.GetMasks(BodyPart.armBack, orientation));

        hand_front.ChangeGloves(gloves.GetSprites(BodyPart.armFront, orientation), gloves.GetMasks(BodyPart.armFront, orientation));
        hand_back.ChangeGloves(gloves.GetSprites(BodyPart.armBack, orientation), gloves.GetMasks(BodyPart.armBack, orientation));
    }

    public void ChangePants(Armor_Pants pants)
    {
        torso.ChangePants(pants.GetSprites(BodyPart.torso, orientation), pants.GetMasks(BodyPart.torso, orientation));
        leg_front.ChangePants(pants.GetSprites(BodyPart.legFront, orientation), pants.GetMasks(BodyPart.legFront, orientation));
        leg_back.ChangePants(pants.GetSprites(BodyPart.legBack, orientation), pants.GetMasks(BodyPart.legBack, orientation));
    }

    public void ChangeBoots(Armor_Boots boots)
    {
        leg_front.ChangeBoots(boots.GetSprites(BodyPart.legFront, orientation), boots.GetMasks(BodyPart.legFront, orientation));
        leg_back.ChangeBoots(boots.GetSprites(BodyPart.legBack, orientation), boots.GetMasks(BodyPart.legBack, orientation));
    }
}
