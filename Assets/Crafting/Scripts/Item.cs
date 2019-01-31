using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Crafting.Items
{
    public class Item : ScriptableObject
    {
		[SerializeField] public string itemName = "new_item";
		[SerializeField] public bool isStackable = false;
		[SerializeField] public int currentStackSize = 1;
		[SerializeField] public int maxStackSize = 99;
		[SerializeField] public Sprite itemSprite;


		public string ItemName { get; set;}
		public bool IsStackable { get; set;}
		public int CurrentStackSize { get; set;}
		public int MaxStackSize { get; set;}
		public Sprite ItemSprite { get; set;}

    }
}