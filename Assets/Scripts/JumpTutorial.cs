using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class JumpTutorial : MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;

    private void Start()
    {
        textBox.enabled = false;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            textBox.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        textBox.enabled = true;
    }
}
