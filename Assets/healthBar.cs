using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthBar : MonoBehaviour


{

    public PlayerMovement playerMovement;
    public TextMeshProUGUI healthText;

     void Start()
    {
    }

     void Update()
    {
        healthText.text = playerMovement.playerHealth.ToString();
    }


}

   

