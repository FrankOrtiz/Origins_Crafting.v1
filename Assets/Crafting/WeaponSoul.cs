using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Crafting.Items {
	
	[CreateAssetMenu(menuName = ("Crafting/WeaponSouls"))]
	public class WeaponSouls : Items.Item {
		public int stamina = 5;
		public int strength = 2;
		public int dexterity = 2;
		public int intellect = 2;
    }
}