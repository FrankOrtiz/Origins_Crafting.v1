using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Crafting;
using UnityEngine.UI;

public class ItemHolderScript : MonoBehaviour {
	public Crafting.Items.Item item;

	void Awake(){
		GetComponent<Image> ().sprite = item.itemSprite;
	}
}
