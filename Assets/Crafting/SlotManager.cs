using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Crafting;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour {

    public Crafting.Items.Item itemInSlot;

	// Use this for initialization
	void Start ()
    {
        if (itemInSlot)
        {
            GameObject itemPanel = transform.GetChild(0).gameObject;
            GameObject item = itemPanel.transform.GetChild(0).gameObject;

            item.GetComponent<Image>().sprite = itemInSlot.GetItemSprite();
            Text itemCount = item.transform.GetChild(0).gameObject.GetComponent<Text>();
            itemCount.text = itemInSlot.GetStackSize().ToString();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
