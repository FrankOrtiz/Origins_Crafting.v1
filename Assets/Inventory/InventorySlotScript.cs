using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlotScript : SlotManagerScript {

	public override bool ProperItemType (GameObject itemBeingDragged) {
		item = itemBeingDragged.gameObject.GetComponent<ItemHolderScript> ().item;
		Debug.Log (item.GetType ().ToString ());
		if (item.GetType ().ToString () == "Crafting.Items.WeaponSouls" || item.GetType ().ToString () == "Crafting.Items.Material" || item.GetType ().ToString () == "Crafting.Items.Weapon") {
			return true;
		}
		return false;
	}
}
