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

    // Use this for initialization
    void Awake()
    {
        weaponInSlot = weaponSlot.transform.GetChild(0).gameObject;
        soulInSlot = soulSlot.transform.GetChild(0).gameObject;
        UpdatePlayerAttributes();
    }

    // Split into AttributesScript
    [SerializeField] int stamina;
    [SerializeField] int strength;
    [SerializeField] int dexterity;
    [SerializeField] int intellect;
    [SerializeField] int minBaseDamage;
    [SerializeField] int maxBaseDamage;

    void UpdatePlayerAttributes() {
        minBaseDamage = weaponInSlot.GetComponent<Weapon>().minWeaponDamage;
        maxBaseDamage = weaponInSlot.GetComponent<Weapon>().maxWeaponDamage;

        stamina = soulInSlot.GetComponent<WeaponSouls>().stamina;
        stamina = soulInSlot.GetComponent<WeaponSouls>().strength;
        stamina = soulInSlot.GetComponent<WeaponSouls>().dexterity;
        stamina = soulInSlot.GetComponent<WeaponSouls>().intellect;

        //statsAmountPanel.transform.GetComponentInChildren
    }
}
