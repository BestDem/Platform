using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionOfKey : MonoBehaviour
{
    [SerializeField] private GameObject keyImageWithDescription;
    [SerializeField] private GameObject keyImage;
    [SerializeField] private Text quantityKey;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            keyImage.SetActive(true);
            keyImageWithDescription.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void QuantityKeyEnter()
    {
        float a = float.Parse(quantityKey.text);
        float coins = a + 1;
        quantityKey.text = $"{coins}";
    }
}
