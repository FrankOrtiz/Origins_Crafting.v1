﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlotScript : SlotManagerScript {
	public Crafting.Items.Weapon weaponInSlot;

    public override bool ProperItemType (GameObject itemBeingDragged) {
        item = itemBeingDragged.gameObject.GetComponent<ItemHolderScript>().item;
        return item.GetType().ToString()== "Crafting.Items.Weapon" ? true : false;
    }

}
