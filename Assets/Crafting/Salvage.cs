using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Crafting.Salvaging {
	using Materials;

	[CreateAssetMenu(menuName = ("Crafting/Salvage"))]
	public class Salvage : Items.Item {

    	[SerializeField] Material baseMaterials;

    }
}