using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int maxStackedItems;
    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;

    //int selectedSlot = -1;

    private void Start()
    {
        //ChangeSelectedSlot(0);    
    }

    private void Update()
    {
        //if (Input.inputString != null)
        //{
        //    bool isNumber = int.TryParse(Input.inputString, out int number);
        //    if (isNumber && number > 0 && number < 9)
        //    {
        //        ChangeSelectedSlot(number - 1);
        //    }
        //}
    }

    //void ChangeSelectedSlot(int newValue)
    //{
    //    if(selectedSlot >= 0)
    //    {
    //        inventorySlots[selectedSlot].DeSelect();
    //    }

    //    inventorySlots[newValue].Select();
    //    selectedSlot = newValue;
    //}

    public bool AddItem(Item item)
    {
        // �ִ�ġ�� �ƴϸ鼭 ���� �������� �������ִ� ���� ã��
        for (int i=0;i<inventorySlots.Length;i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot != null && itemInSlot.item == item && itemInSlot.count < maxStackedItems && itemInSlot.item.stackable == true)
            {
                itemInSlot.count++;
                itemInSlot.RefreshCount();
                return true;
            }
        }

        // �� ���� ã��
        for (int i=0;i<inventorySlots.Length;i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if(itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return true;
            }
        }
        return false;
    }

    void SpawnNewItem(Item item,InventorySlot slot)
    {
        GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
    }
}