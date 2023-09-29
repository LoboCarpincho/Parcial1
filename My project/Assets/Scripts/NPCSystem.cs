using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCSystem : MonoBehaviour
{
    public GameObject dTemplate;
    public GameObject canva;
    bool playerDetection = false;
    
    void Update()
    {
        if(playerDetection && Input.GetKeyDown(KeyCode.F) && !PlayerMovement.dialogue)
        {
            canva.SetActive(true);
            PlayerMovement.dialogue = true;
            NewDialogue("Recluta!");
            NewDialogue("Encontramos un planeta habitable, pero esta rodeado de basura");
            NewDialogue("Te vamos a mandar para alla, aterriza en el plante y ganaste");
            NewDialogue("Doblando a tu derecha esta el portal para tepearte a tu nave");
            NewDialogue("Suerte! nwn");
            canva.transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    void NewDialogue(string text)
    {
        GameObject templateClone = Instantiate(dTemplate, dTemplate.transform);
        templateClone.transform.parent = canva.transform;
        templateClone.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = text;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            playerDetection = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        playerDetection = false;
    }
}
