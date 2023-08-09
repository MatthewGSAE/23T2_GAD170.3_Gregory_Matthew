using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SprintTutorial : MonoBehaviour
{
    [SerializeField] private TextMeshPro sprinttextBox;

    private void Start()
    {
        sprinttextBox.enabled = false;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprinttextBox.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        sprinttextBox.enabled = true;
    }
}
