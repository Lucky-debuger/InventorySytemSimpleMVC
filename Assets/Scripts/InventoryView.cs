using System.Collections.Generic;
using UnityEngine;

public class InventoryView : MonoBehaviour
{
    [SerializeField] InventoryController inventoryController;
    [SerializeField] GameObject slot;
    [SerializeField] Transform inventoryPanel;

    private List<SlotView> slotViews = new List<SlotView>();

    private void Awake()
    {
        inventoryController.OnItemAdded += DrawSlots;
    }

    private void DrawSlots(ItemModel item)
    {
        foreach (SlotView slot in slotViews)
        {
            if (slot.GetItem() == item)
            {
                slot.IncreaseCount();
                return;
            }
        }
        CreateSlot(item);
    }

    private void CreateSlot(ItemModel item)
    {
        SlotView slotView = Instantiate(slot, inventoryPanel).GetComponent<SlotView>();
        slotView.SetItem(item);
        slotView.Render();
        slotViews.Add(slotView); // Как добавить в определенное место?
    }
}
