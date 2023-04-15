using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemsToPickUp;

    public void PickUpItem(int id)
    {
        bool result = inventoryManager.AddItem(itemsToPickUp[id]);
        if(result)
        {
            Debug.Log("������ �߰�");
        }
        else
        {
            Debug.Log("������ �߰� ���� / �κ��丮 ���� ����");
        }
    }
}
