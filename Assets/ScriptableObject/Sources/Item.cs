using UnityEngine;

[CreateAssetMenu(fileName ="ItemData",menuName ="MyObjects/Items")]
public class Item : ScriptableObject
{
    public string Name = "Item";
    public string Type = "Type";
    public Sprite Icon;
}
