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
            Debug.Log("아이템 추가");
        }
        else
        {
            Debug.Log("아이템 추가 실패 / 인벤토리 공간 부족");
        }
    }
}
