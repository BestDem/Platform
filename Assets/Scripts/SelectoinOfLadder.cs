using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectoinOfLadder : MonoBehaviour
{
    [SerializeField] private GameObject ladderImageWithDescription;
    [SerializeField] private Text quantityLadder;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            ladderImageWithDescription.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void QuantityLadderEnter()
    {
        float a = float.Parse(quantityLadder.text);
        float coins = a + 1;
        quantityLadder.text = $"{coins}";
    }
}
