using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Crafting.Items {
	
	[CreateAssetMenu(menuName = ("Crafting/Weapon"))]
	public class Weapon : Items.Item {
		public int minWeaponDamage = 1;
		public int maxWeaponDamage = 3;
    }
}