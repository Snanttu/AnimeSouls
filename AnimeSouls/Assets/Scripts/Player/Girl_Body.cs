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

    public void ChangeGloves(Sprite[] sprites, Sprite[] masks)
    {

    }

    public void ChangePants(Sprite[] sprites, Sprite[] masks)
    {

    }

    public void ChangeBoots(Sprite[] sprites, Sprite[] masks)
    {

    }
}
