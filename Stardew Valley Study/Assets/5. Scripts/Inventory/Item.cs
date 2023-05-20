using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName ="Scriptable object/Item")]
public class Item : ScriptableObject
{
    public ItemType itemType;

    public bool stackable = true;

    public Sprite image;
}

public enum ItemType
{
    Block,
    Tool
}