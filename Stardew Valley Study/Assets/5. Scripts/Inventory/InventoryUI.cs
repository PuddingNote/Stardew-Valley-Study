using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    bool activeInventory = false;

    private void Start()
    {
        inventory.SetActive(activeInventory);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            activeInventory = !activeInventory;
            inventory.SetActive(activeInventory);
        }
    }

}
