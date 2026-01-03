using System;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] private InventoryModel inventoryModel;
    
    private ItemModel _selectSlot;
    
    public event Action<ItemModel> OnItemAdded;
    public event Action OnItemDeleted;
    
    public void SelectSlot(SlotView slot)
    {
        _selectSlot = slot.GetItem();
    }

    public void AddSelectedItem()
    {
        inventoryModel.AddItem(_selectSlot);
        OnItemAdded?.Invoke(_selectSlot);
    }

    public void DeleteItem(ItemModel item)
    {
        
    }
}
