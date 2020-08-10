using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Item item;

    private void Start()
    {
        Debug.Log(item.name);
        Debug.Log(item.id);
        Debug.Log(item.buff.attribute + " = " + item.buff.value);
    }
}
