using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment_Manager : MonoBehaviour
{
    [Header("Equipped Items")]
    [SerializeField]
    private Armor_Shirt _equippedChest;
    [SerializeField]
    private Armor_Pants _equippedPants;
    [SerializeField]
    private Armor_Gloves _equippedGloves;
    [SerializeField]
    private Armor_Boots _equippedBoots;

    [Header("Body")]
    [SerializeField]
    private Girl_Body bodyFront;
    [SerializeField]
    private Girl_Body bodySide;
    [SerializeField]
    private Girl_Body bodyBack;

    [SerializeField]
    [HideInInspector]
    private Armor_Shirt _currentChest;
    [SerializeField]
    [HideInInspector]
    private Armor_Pants _currentPants;
    [SerializeField]
    [HideInInspector]
    private Armor_Boots _currentBoots;
    [SerializeField]
    [HideInInspector]
    private Armor_Gloves _currentGloves;

    // Start is called before the first frame update
    void Start()
    {
        ChangeChest();
        ChangePants();
        ChangeBoots();
        ChangeGloves();
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentChest != _equippedChest)
        {
            ChangeChest();
        }

        if (_currentPants != _equippedPants)
        {
            ChangePants();
        }

        if (_currentBoots != _equippedBoots)
        {
            ChangeBoots();
        }

        if (_currentGloves != _equippedGloves)
        {
            ChangeGloves();
        }
    }

    public void ChangeChest()
    {

        _currentChest = _equippedChest;
    }

    public void ChangePants()
    {

        _currentPants = _equippedPants;
    }
    public void ChangeBoots()
    {

        _currentBoots = _equippedBoots;
    }

    public void ChangeGloves()
    {

        _currentGloves = _equippedGloves;
    }
}
