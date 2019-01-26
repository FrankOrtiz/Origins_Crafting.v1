using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Crafting.Items
{
    public class Item : ScriptableObject
    {
        [SerializeField] string itemName = "new_material";
        [SerializeField] bool isStackable = true;
        [SerializeField] int currentStackSize = 1;
        [SerializeField] int maxStackSize = 99;
        [SerializeField] GameObject gameObject;
        [SerializeField] Sprite itemSprite;

        public Sprite GetItemSprite()
        {
            return itemSprite;
        }


        public void ChangeCurrentStackSize(int amount)
        {
            if (isStackable)
            {
                int new_amout = currentStackSize + amount;

                if (new_amout <= maxStackSize)
                {
                    currentStackSize = new_amout;
                }
                else if (new_amout >= maxStackSize)
                {
                    currentStackSize = maxStackSize;
                }
            }
            currentStackSize += amount;
        }

        public int GetStackSize()
        {
            return currentStackSize;
        }
    }
}