using System;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}
