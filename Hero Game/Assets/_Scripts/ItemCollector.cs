using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private int fruits;
    [SerializeField] private TextMeshProUGUI fruitText;
    [SerializeField] private PlayerMovement playerMovement;

    

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruits"))
        {
            Destroy(collision.gameObject);
            fruits++;
            fruitText.text = "Meyve : " + fruits;
            Debug.Log("Elma Alýndý");
            
        }

        if (collision.gameObject.CompareTag("SizeObject"))
        {
            playerMovement.SetPlayerSize();
        }
    }
}


