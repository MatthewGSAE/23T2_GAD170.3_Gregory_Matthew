using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class JumpTutorial : MonoBehaviour
{
    [SerializeField] private TextMeshPro jumptextBox;

    private void Start()
    {
        jumptextBox.enabled = false;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumptextBox.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        jumptextBox.enabled = true;
    }
}
