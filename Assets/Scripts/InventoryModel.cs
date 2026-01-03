using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObjects/Inventory/Inventory", order = 0)]
public class InventoryModel : ScriptableObject // Зачем делать его ScriptableObject?
{
   private Dictionary<ItemModel, int> items = new();
}
