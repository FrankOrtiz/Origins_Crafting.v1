using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropHandler : MonoBehaviour, IDropHandler {
	Transform parentSlot;

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

		if (parentSlot.GetComponent<ItemDropHandler>().ProperItemType(ItemDragHandler.itemBeingDragged)){
			DropItemIntoSlot ();
		}
	}

	public virtual bool ProperItemType(GameObject itemBeingDragged){
		Debug.Log ("Base");
		return false;
	}

	public void DropItemIntoSlot(){
		if (itemInSlot) {
			itemInSlot.transform.position = ItemDragHandler.startPosition;
			itemInSlot.transform.SetParent (ItemDragHandler.startParent);
		}

		ItemDragHandler.itemBeingDragged.transform.SetParent (parentSlot);
	}
}
