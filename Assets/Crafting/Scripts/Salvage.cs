using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Crafting.Salvaging {
	using Crafting.Items;

	[CreateAssetMenu(menuName = ("Crafting/Salvage"))]
	public class Salvage : Items.Item {

    	[SerializeField] Material baseMaterials;

    }
}