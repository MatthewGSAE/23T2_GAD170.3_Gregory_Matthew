using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DEATH : MonoBehaviour
{
    [SerializeField] PlayerCharacter playercharacter;

    [SerializeField] TextMeshPro textBox;

    [SerializeField] GameObject playerCharacter;

    [SerializeField] CharacterController controller;

    private void Start()
    {
       textBox.enabled = false;
    }

    private void Update()
    {
        Respawn();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Dead");
            textBox.enabled = true;
            playercharacter.isAlive = false;
        }
    }

    private void Respawn()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (controller != null)
            {
                controller.enabled = false;
            }
            Vector3 teleportPosition = new Vector3(7.75f, 2.599999f, -9.310002f);
            playerCharacter.transform.position = teleportPosition;
            Debug.Log("Alive");
            textBox.enabled = false;
            playercharacter.isAlive = true;
            controller.enabled = true;
        }
    }
}