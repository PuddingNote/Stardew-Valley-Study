using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] 
    private GameObject maininventory;

    [SerializeField]
    private GameObject toolbar;

    bool activeInventory = false;

    private void Start()
    {
        maininventory.SetActive(activeInventory);
        toolbar.SetActive(!activeInventory);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            activeInventory = !activeInventory;
            maininventory.SetActive(activeInventory);
            toolbar.SetActive(!activeInventory);
        }
    }

}
