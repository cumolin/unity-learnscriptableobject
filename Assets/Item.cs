using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Create Item")]
public class Item : ScriptableObject
{
    public string name;
    public int id;
    public string description;

    public Buff buff;
}

public enum Attributes
{
    TypeA,
    TypeB,
    TypeC
}

[System.Serializable]
public class Buff
{
    public Attributes attribute;
    public int value;
}


