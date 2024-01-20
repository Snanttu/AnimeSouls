using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment_Manager : MonoBehaviour
{
    [Header("Equipped Items")]
    [SerializeField]
    private Armor_Shirt equippedShirt;
    [SerializeField]
    private Armor_Pants equippedPants;
    [SerializeField]
    private Armor_Gloves equippedGloves;
    [SerializeField]
    private Armor_Boots equippedBoots;

    [Header("Body")]
    [SerializeField]
    private Girl_Body bodyFront;
    [SerializeField]
    private Girl_Body bodySide;
    [SerializeField]
    private Girl_Body bodyBack;

    [SerializeField]
    [HideInInspector]
    private Armor_Shirt currentShirt;
    [SerializeField]
    [HideInInspector]
    private Armor_Pants currentPants;
    [SerializeField]
    [HideInInspector]
    private Armor_Boots currentBoots;
    [SerializeField]
    [HideInInspector]
    private Armor_Gloves currentGloves;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnValidate()
    {
        if (currentShirt != equippedShirt) ChangeChest();
        if (currentPants != equippedPants) ChangePants();
        if (currentBoots != equippedBoots) ChangeBoots();
        if (currentGloves != equippedGloves) ChangeGloves();
    }

    public void ChangeChest()
    {
        bodyFront.ChangeShirt(equippedShirt);
        bodySide.ChangeShirt(equippedShirt);
        bodyBack.ChangeShirt(equippedShirt);

        currentShirt = equippedShirt;
    }

    public void ChangePants()
    {
        bodyFront.ChangePants(equippedPants);
        bodySide.ChangePants(equippedPants);
        bodyBack.ChangePants(equippedPants);

        currentPants = equippedPants;
    }
    public void ChangeBoots()
    {
        bodyFront.ChangeBoots(equippedBoots);
        bodySide.ChangeBoots(equippedBoots);
        bodyBack.ChangeBoots(equippedBoots);

        currentBoots = equippedBoots;
    }

    public void ChangeGloves()
    {
        bodyFront.ChangeGloves(equippedGloves);
        bodySide.ChangeGloves(equippedGloves);
        bodyBack.ChangeGloves(equippedGloves);

        currentGloves = equippedGloves;
    }
}
