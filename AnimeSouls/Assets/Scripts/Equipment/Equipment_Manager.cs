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

    [SerializeField]
    private SpriteRenderer[] _chestSprites;
    [SerializeField]
    private SpriteMask[] _chestMasks;
    [SerializeField]
    private SpriteRenderer[] _chestSkirtSprites;
    [SerializeField]
    private SpriteRenderer[] _shoulderSprites;
    [SerializeField]
    private SpriteRenderer[] _pantsSprites;
    [SerializeField]
    private SpriteMask[] _pantsMasks;
    [SerializeField]
    private SpriteRenderer[] _glovesSprites;
    [SerializeField]
    private SpriteMask[] _glovesMasks;
    [SerializeField]
    private SpriteRenderer[] _handSprites;
    [SerializeField]
    private SpriteRenderer[] _bootsSprites;
    [SerializeField]
    private SpriteMask[] _bootsMasks;

    private Armor_Shirt _currentChest;
    private Armor_Pants _currentPants;
    private Armor_Boots _currentBoots;
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
        for (int i = 0; i < _chestSprites.Length; i++)
        {
            _chestSprites[i].sprite = _equippedChest.GetChestSprite(i);
        }

        for (int i = 0; i < _chestMasks.Length; i++)
        {
            _chestMasks[i].sprite = _equippedChest.GetMask(i);
        }

        for (int i = 0; i < _chestSkirtSprites.Length; i++)
        {
            _chestSkirtSprites[i].sprite = _equippedChest.GetSkirtSprite(i);
        }

        for (int i = 0; i < _shoulderSprites.Length; i++)
        {
            _shoulderSprites[i].sprite = _equippedChest.GetShoulderSprite(i);
        }

        _currentChest = _equippedChest;
    }

    public void ChangePants()
    {
        for (int i = 0; i < _pantsSprites.Length; i++)
        {
            _pantsSprites[i].sprite = _equippedPants.GetSprite(i);
        }

        for (int i = 0; i < _pantsMasks.Length; i++)
        {
            _pantsMasks[i].sprite = _equippedPants.GetMask(i);
        }

        _currentPants = _equippedPants;
    }
    public void ChangeBoots()
    {
        for (int i = 0; i < _bootsSprites.Length; i++)
        {
            _bootsSprites[i].sprite = _equippedBoots.GetSprite(i);
        }

        for (int i = 0; i < _bootsMasks.Length; i++)
        {
            _bootsMasks[i].sprite = _equippedBoots.GetMask(i);
        }

        _currentBoots = _equippedBoots;
    }

    public void ChangeGloves()
    {
        for (int i = 0; i < _glovesSprites.Length; i++)
        {
            _glovesSprites[i].sprite = _equippedGloves.GetGlovesSprite(i);
        }

        for (int i = 0; i < _glovesMasks.Length; i++)
        {
            _glovesMasks[i].sprite = _equippedGloves.GetMask(i);
        }

        for (int i = 0; i < _handSprites.Length; i++)
        {
            _handSprites[i].sprite = _equippedGloves.GetHandsSprite(i);
        }

        _currentGloves = _equippedGloves;
    }
}
