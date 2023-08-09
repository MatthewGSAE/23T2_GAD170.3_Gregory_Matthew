using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonTutorial : MonoBehaviour
{
    [SerializeField] private TextMeshPro buttontextBox;

    private void Start()
    {
        buttontextBox.enabled = false;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            buttontextBox.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        buttontextBox.enabled = true;
    }
}
