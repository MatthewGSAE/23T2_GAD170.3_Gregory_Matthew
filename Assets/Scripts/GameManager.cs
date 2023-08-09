using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject playerCharacter;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private CharacterController controller;

    public bool isAlive = true;

    // death text box
    [SerializeField] private TextMeshPro textBox;

    // Start is called before the first frame update
    void Start()
    {
       textBox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.enabled == false)
        {
            playerCharacter.transform.position = spawnPoint.position;
            controller.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("cytv");
            controller.enabled = false;
            textBox.enabled = false;
            isAlive = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("mrtcgvhb");
        if (other.CompareTag("Player"))
        {
            Debug.Log("dead");
            textBox.enabled = true;
            isAlive = false;
        }
    }
}