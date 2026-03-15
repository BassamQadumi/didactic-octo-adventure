using UnityEngine;

public class Shop : MonoBehaviour
{
    public Inventory inventory;

 
    public void BuyStick()
    {
        inventory.stick = true;
        Debug.Log("Stick Purchased");
    }

   
    public void BuyStone()
    {
        inventory.stone = true;
        Debug.Log("Stone Purchased");
    }

  
    public void BuyWater()
    {
        inventory.water = true;
        Debug.Log("Water Purchased");
    }

    
    public void BuyBook()
    {
        inventory.book = true;
        Debug.Log("Book Purchased");
    }
}