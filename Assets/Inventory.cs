using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public PlayerMovement playerMovement;

// aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa

    public GameObject canvasInventory;

    public bool stick = false;
    public bool stone = false;
    public bool water = false;
    public bool book = false;

    private bool isActive = false;

    void Start()
    {
        if (canvasInventory != null)
            canvasInventory.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            isActive = !isActive;
            if (canvasInventory != null)
                canvasInventory.SetActive(isActive);
        }
    }


    public void UseWater()
    {
        water = false;
        playerMovement.playerHealth += 15;
    }

    


}