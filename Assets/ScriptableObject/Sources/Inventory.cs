using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] List<Item> StartItems = new List<Item>();
    public List<Item> allItems = new List<Item>();
    void Start()
    {
        for (var i = 0; i < StartItems.Count; i++)
        {
            AddItem(StartItems[i]);
        }
    }

    void Update()
    {
        
    }

    void AddItem(Item item)
    {
        allItems.Add(item);
    }
}
