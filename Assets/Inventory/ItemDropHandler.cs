using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropHandler : MonoBehaviour, IDropHandler {
	Transform parentSlot;
    public PlayerScript playerScript;

    private void Awake()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    public GameObject itemInSlot{
		get { 
			if (parentSlot.childCount > 0){
				return parentSlot.GetChild (0).transform.gameObject;
			}
			return null;
		}
	}

	public void OnDrop(PointerEventData eventData){
		
		if (transform.CompareTag ("Item")) {
			parentSlot = transform.parent;
		} else {
			parentSlot = transform;
		}

        // only handles IF item exists in the slot moving to
        bool itemDraggedFitsIntoTargetParentSlot = parentSlot.GetComponent<ItemDropHandler>().ProperItemType(ItemDragHandler.itemBeingDragged);
        bool itemInTargetSlotFitsIntoParentSlot = itemInSlot && ItemDragHandler.itemBeingDragged.transform.parent.GetComponent<ItemDropHandler>().ProperItemType(itemInSlot);

        if (itemDraggedFitsIntoTargetParentSlot && itemInTargetSlotFitsIntoParentSlot){
			DropItemIntoSlot ();
            SetEquipment();
        }
	}

	public virtual bool ProperItemType(GameObject itemBeingDragged){
		Debug.Log ("Item type not registered.");
		return false;
	}

	public void DropItemIntoSlot(){
        // TODO Handle slot acceptence check before itemInSlot is re-registered to dragged item's previous slot
        // IsEquippable() IsCorrectSlot() CanBePlacedIntoSlot() ect...
        if (itemInSlot) // If there is an item currently in target slot
        {
            itemInSlot.transform.position = ItemDragHandler.startPosition;
            itemInSlot.transform.SetParent(ItemDragHandler.startParent);

            ItemDragHandler.itemBeingDragged.transform.SetParent(parentSlot);
        }

        if (!(ItemDragHandler.itemBeingDragged.transform.parent.name == "WeaponSlot") && !(ItemDragHandler.itemBeingDragged.transform.parent.name == "SoulSlot")) {
            ItemDragHandler.itemBeingDragged.transform.SetParent(parentSlot);

        }
    }

    void SetEquipment()
    {
        // TODO change to subscription hook
        switch (ItemDragHandler.itemBeingDragged.GetComponent<ItemHolderScript>().item.GetType().ToString())
        {
            case "Crafting.Items.WeaponSouls":
                if (parentSlot.name == "SoulSlot")
                    playerScript.UpdateSoulEquipped();
                break;
            case "Crafting.Items.Weapon":
                if (parentSlot.name == "WeaponSlot")
                    playerScript.UpdateWeaponEquipped();
                break;
            default:
                break;
        }
    }
}
