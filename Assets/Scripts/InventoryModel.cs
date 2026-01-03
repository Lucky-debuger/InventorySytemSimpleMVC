using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObjects/Inventory/Inventory", order = 0)]
public class InventoryModel : ScriptableObject
{
    private Dictionary<ItemModel, int> items = new();

    public void AddItem(ItemModel item)
    {
        items.TryAdd(item, 1);
    }
}
