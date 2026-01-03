using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotView : MonoBehaviour
{
    [SerializeField] private ItemModel item; // item можно сделать так public ItemModel Item { get; private set; } . Разобраться зачем
    [SerializeField] private TMP_Text itemCount;

    [SerializeField] private TMP_Text itemName;
    [SerializeField] private TMP_Text description;
    [SerializeField] private Image itemIcon;
    [SerializeField] private Image descriptionIcon;


    private void Awake() // Убрать!
    {
        description = GameObject.Find("DescriptionText").GetComponent<TMP_Text>();
        descriptionIcon = GameObject.Find("DescriptionIcon").GetComponent<Image>();
        Render();
    }
    private int _itemCount = 1;

    public void SetItem(ItemModel itemModel)
    {
        item = itemModel;
    }

    public ItemModel GetItem()
    {
        return item;
    }

    public void Render()
    {
        if (item == null) return;

        itemName.text = item.Name;
        itemIcon.sprite = item.Icon;
        description.text = item.Description;
        descriptionIcon.sprite = item.Icon;
        itemCount.text = _itemCount.ToString();
        
    }

    public void IncreaseCount()
    {
        _itemCount += 1;
        itemCount.text = _itemCount.ToString();
    }

}
