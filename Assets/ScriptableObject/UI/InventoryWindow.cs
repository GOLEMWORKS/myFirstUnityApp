using UnityEngine;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] Inventory targetInventory;
    [SerializeField] RectTransform itemsPanel;
    void Start()
    {
        
    }

    void Redraw()
    {
        for (var i = 0; i < targetInventory.allItems.Count; i++)
        {
            var icon = new GameObject(name: "Icon");
            //Рано браться за инвентарь. останется на будущую доработку
        }
    }
}
