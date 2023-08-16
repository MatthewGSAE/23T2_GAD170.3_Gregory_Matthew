using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    [SerializeField] TextMeshPro tutorialText;

    // Start is called before the first frame update
    void Start()
    {
        tutorialText.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        tutorialText.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        tutorialText.enabled = false;
    }
}