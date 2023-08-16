using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoveText : MonoBehaviour
{
    [SerializeField] TextMeshPro moveText;

    private void OnTriggerExit(Collider other)
    {
        moveText.enabled = false;
    }
}
