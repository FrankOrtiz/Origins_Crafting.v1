using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Crafting;
using UnityEngine.UI;

public class SlotManagerScript : ItemDropHandler {
    public Crafting.Items.Item item;

	[SerializeField] bool isStackable;
	[SerializeField] int currentStackSize;
	[SerializeField] int maxStackSize;
	[SerializeField] Text itemCountText;

	// Use this for initialization
//	void Start ()
//	{
//
//		if (itemInSlot)
//		{
//		switch (itemInSlot.GetType ().ToString()) {
//		case "Crafting.Weapons.Weapon":
//			weaponInSlot = itemInSlot as Crafting.Items.Weapon;
//			break;
//		case "Crafting.Items.Material":
//			materialInSlot = itemInSlot as Crafting.Items.Material;
//			break;
//		case "Crafting.Items.WeaponSouls":
//			weaponSoulInSlot = itemInSlot as Crafting.Items.WeaponSouls;
//			break;
//		default:
//			break;
//		}
//			UpdateCharacterStatsWithWeaponSoul ();
//			isStackable = itemInSlot.isStackable;
//			currentStackSize = itemInSlot.currentStackSize;
//			maxStackSize = itemInSlot.maxStackSize;
//
//            GameObject itemPanel = transform.GetChild(0).gameObject;
//            GameObject item = itemPanel.transform.GetChild(0).gameObject;
//
//			item.GetComponent<Image>().sprite = itemInSlot.itemSprite;
//			if (isStackable) {
//				itemCountText = item.transform.GetChild(0).gameObject.GetComponent<Text>();
//				itemCountText.text = itemInSlot.currentStackSize.ToString();
//			}
//        }
//	}
//
//
//	public void ChangeCurrentStackSize(int amount)
//	{
//		if (isStackable)
//		{
//			int new_amout = currentStackSize + amount;
//
//			if (new_amout < maxStackSize)
//			{
//				currentStackSize = new_amout;
//			}
//			else if (new_amout >= maxStackSize)
//			{
//				currentStackSize = maxStackSize;
//				Debug.Log ("Max stack size reached.");
//				// Do something
//			}
//		}
//
//		UpdateStackSizeCount ();
//	}
//
//	public int GetStackSize()
//	{
//		return currentStackSize;
//	}
//
//	public void UpdateStackSizeCount(){
//		itemCountText.text = currentStackSize.ToString();
//	}
//
//	public int GetStamina(){
//		if (weaponSoulInSlot) {
//			return weaponSoulInSlot.stamina;
//		}
//		return 0;
//	}
//
//	public void UpdateCharacterStatsWithWeaponSoul(){
//		if (gameObject.CompareTag ("WeaponSoulSlot")) {
//			Debug.Log (weaponSoulInSlot.stamina);
//		}
//	}
}
