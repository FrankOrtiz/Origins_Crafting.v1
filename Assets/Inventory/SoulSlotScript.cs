using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulSlotScript : SlotManagerScript {
	public Crafting.Items.WeaponSouls soulInSlot;

    public override bool ProperItemType (GameObject itemBeingDragged) {
		item = itemBeingDragged.gameObject.GetComponent<ItemHolderScript> ().item;
        return item.GetType().ToString() == "Crafting.Items.WeaponSouls" ? true : false;
    }
}
