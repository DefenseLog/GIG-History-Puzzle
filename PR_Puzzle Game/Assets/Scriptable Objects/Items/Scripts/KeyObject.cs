using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyType
{
    Metal,
    Green,
    Chest,
    Default
}

[CreateAssetMenu(fileName = "New Key Object", menuName = "Inventory System/Items/Key")]
public class KeyObject : ItemObject
{
    public KeyType keyType;
    public void Awake()
    {
        type = ItemType.Keys;
    }
}
