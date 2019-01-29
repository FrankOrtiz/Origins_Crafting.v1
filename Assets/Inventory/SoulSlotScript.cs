using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulSlotScript : SlotManagerScript {
	public Crafting.Items.WeaponSouls soulInSlot;

	public override bool ProperItemType (GameObject itemBeingDragged) {
		item = itemBeingDragged.gameObject.GetComponent<ItemHolderScript> ().item;
		Debug.Log (item.GetType ().ToString ());
		if (item.GetType ().ToString () == "Crafting.Items.WeaponSouls") {
			return true;
		}
		return false;
	}
}
