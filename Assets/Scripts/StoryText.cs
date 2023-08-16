using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoryText : MonoBehaviour
{
    [SerializeField] TextMeshPro storyText;

    // Start is called before the first frame update
    void Start()
    {
        storyText.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        storyText.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        storyText.enabled = false;
    }
}
