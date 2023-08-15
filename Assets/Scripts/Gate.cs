using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    [SerializeField] GameObject gate;

    [SerializeField] private float movespeed = 5;

    private bool playerNextToButton = false;

    private float deadzone = 13.71f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && playerNextToButton)
        {
            Debug.Log("E has been pressed");
            gate.transform.position = gate.transform.position + (Vector3.down * movespeed) * Time.deltaTime;
            if (transform.position.y < deadzone)
            {
                Destroy(gate);
            }
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("next top button");
            playerNextToButton = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("not next to button");
            playerNextToButton = false;
        }
    }
}