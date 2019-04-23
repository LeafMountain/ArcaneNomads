using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class InventoryUIButton : MonoBehaviour
{
    public StorableComponent storable;
    public Image buttonIcon;

    Button button;
    Text buttonText;

    void Awake()
    {
        ClearStorable();
        button = GetComponent<Button>();
    }
    
    public void SetStorable(StorableComponent storable)
    {
        if(!storable)
        {
            ClearStorable();
            return;
        }

        this.storable = storable;
        buttonIcon.sprite = storable.icon;
        button.onClick.AddListener(() => ExtractStorable());
        buttonIcon.color = Color.white;
    }

    public StorableComponent ExtractStorable()
    {
        StorableComponent extractedStorable = storable;
        storable = null;
        extractedStorable.DropFromInventory();
        // extractedStorable.transform.position = transform.position + transform.forward;  // Places the item at the BUTTON POSITION
        return storable;
    }

    public void ClearStorable()
    {
        storable = null;
        buttonIcon.sprite = null;
        buttonIcon.color = Color.clear;
        button.onClick.RemoveAllListeners();
        // remove event as well
    }
}
