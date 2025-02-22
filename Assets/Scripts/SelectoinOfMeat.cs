using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectoinOfMeat : MonoBehaviour
{
    [SerializeField] private GameObject meatImageWithDescription;
    [SerializeField] private Text quantityMeat;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            meatImageWithDescription.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void QuantityMeatEnter()
    {
        float a = float.Parse(quantityMeat.text);
        float coins = a + 1;
        quantityMeat.text = $"{coins}";
    }
}
