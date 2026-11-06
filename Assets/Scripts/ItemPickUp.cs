using System;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        gameObject.SetActive(false);
    }
}
