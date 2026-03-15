using UnityEngine;

public class ShopTrigger : MonoBehaviour
{
    public GameObject canvasTip;
    public GameObject canvasShop;

    private bool playerInside = false;

    void Start()
    {
        canvasTip.SetActive(false);
        canvasShop.SetActive(false);
    }

    void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.F))
        {
            canvasShop.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            canvasTip.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
            canvasTip.SetActive(false);
            canvasShop.SetActive(false);
        }
    }
}