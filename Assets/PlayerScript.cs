using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Crafting.Items;

public class PlayerScript : MonoBehaviour {
    public GameObject weaponSlot;
    public GameObject soulSlot;
    public GameObject statsAmountPanel;

    [SerializeField] GameObject weaponInSlot;
    [SerializeField] GameObject soulInSlot;

    Weapon weaponEquipped;
    WeaponSouls weaponSoulEquipped;

    // Use this for initialization
    void Start()
    {
        UpdateEquipmentEquipped();
    }

    public void UpdateWeaponEquipped()
    {
        weaponInSlot = weaponSlot.transform.GetChild(0).gameObject;
        weaponEquipped = weaponInSlot.GetComponent<ItemHolderScript>().item as Weapon;

        minBaseDamage = weaponEquipped.minWeaponDamage;
        maxBaseDamage = weaponEquipped.maxWeaponDamage;

        Debug.Log("Equipped: " + weaponEquipped.itemName);

        statsAmountPanel.transform.Find("DamageRangeAmountText").GetComponent<Text>().text = minBaseDamage.ToString() + " - " + maxBaseDamage.ToString();
    }

    public void UpdateSoulEquipped()
    {
        soulInSlot = soulSlot.transform.GetChild(0).gameObject;
        weaponSoulEquipped = soulInSlot.GetComponent<ItemHolderScript>().item as WeaponSouls;

        stamina = weaponSoulEquipped.stamina;
        strength = weaponSoulEquipped.strength;
        dexterity = weaponSoulEquipped.dexterity;
        intellect = weaponSoulEquipped.intellect;

        Debug.Log("Equipped: " + weaponSoulEquipped.itemName);

        statsAmountPanel.transform.Find("StaminaAmountText").GetComponent<Text>().text = stamina.ToString();
        statsAmountPanel.transform.Find("StrengthAmountText").GetComponent<Text>().text = strength.ToString();
        statsAmountPanel.transform.Find("DexterityAmountText").GetComponent<Text>().text = dexterity.ToString();
        statsAmountPanel.transform.Find("IntellectAmountText").GetComponent<Text>().text = intellect.ToString();
    }

    void UpdateEquipmentEquipped()
    {
        UpdateWeaponEquipped();
        UpdateSoulEquipped();
    }

    // Split into AttributesScript
    [SerializeField] int stamina;
    [SerializeField] int strength;
    [SerializeField] int dexterity;
    [SerializeField] int intellect;
    [SerializeField] int minBaseDamage;
    [SerializeField] int maxBaseDamage;
}
