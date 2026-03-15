using UnityEngine;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    public Inventory playerInventory;
    public List<GameObject> itemObjects;

    void Update()
    {
        if (playerInventory == null || itemObjects.Count < 4)
            return;

        
        itemObjects[0].SetActive(playerInventory.stick);
        
        itemObjects[1].SetActive(playerInventory.stone);
       
        itemObjects[2].SetActive(playerInventory.water);
      
        itemObjects[3].SetActive(playerInventory.book);
    }
}