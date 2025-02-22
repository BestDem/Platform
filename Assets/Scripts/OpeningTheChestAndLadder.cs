using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OpeningTheChestAndLadder : MonoBehaviour
{
    [SerializeField] private Text quantityKey;
    [SerializeField] private GameObject canOpenTheChest;
    [SerializeField] private GameObject needKeyForChest;
    [SerializeField] private GameObject gameObjectLadder;
    [SerializeField] private GameObject LadderButton;
    [SerializeField] private GameObject PauseButton;
    
    private float selectionKey;


    private void OnTriggerEnter2D(Collider2D collider)
    {
        float.TryParse(quantityKey.text, out selectionKey);

        if(selectionKey == 1)
        {
           canOpenTheChest.SetActive(true);
           PauseButton.SetActive(false);
        }

        else
        {
            needKeyForChest.SetActive(true);
            PauseButton.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canOpenTheChest.SetActive(false);
        needKeyForChest.SetActive(false);
        PauseButton.SetActive(true);
    }

    public void ChestButtonPress()
    {
        quantityKey.text = "0";
    }

    public void TurnOnLadder()
    {
        gameObjectLadder.SetActive(true);
        LadderButton.SetActive(true);
        Destroy(canOpenTheChest);
        Destroy(needKeyForChest);
    }
}
