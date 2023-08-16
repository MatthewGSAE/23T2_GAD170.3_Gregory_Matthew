using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{

    [SerializeField] private GameObject arrowPrefabe;
    [SerializeField] private GameObject spawnerObject;

    private float moveSpeed = 5;
    private void OnTriggerEnter(Collider other)
    {
        GameObject newArrow = Instantiate(arrowPrefabe, spawnerObject.transform.position, spawnerObject.transform.rotation);
        newArrow.transform.position = newArrow.transform.position + (transform.forward * moveSpeed) * Time.deltaTime;
    }
}