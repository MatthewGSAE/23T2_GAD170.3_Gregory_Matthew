using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gate : MonoBehaviour
{

    [SerializeField] GameObject gate;

    [SerializeField] private float movespeed = 5;

    private bool playerNextToButton = false;

    [SerializeField] private TextMeshPro textBox;


    // Update is called once per frame
    void Start()
    {
        textBox.enabled = false;
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && playerNextToButton)
        {
            Debug.Log("E has been pressed");
            gate.transform.position = gate.transform.position + (Vector3.down * movespeed) * Time.deltaTime;
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("next top button");
            playerNextToButton = true;
            textBox.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("not next to button");
            playerNextToButton = false;
            textBox.enabled = false;
        }
    }
}