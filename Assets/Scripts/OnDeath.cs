using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnDeath : MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;

    // Update is called once per frame

    private void Start()
    {
        textBox.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
       //player dead
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            //respawn player

            textBox.enabled = false;
        }
    }
}