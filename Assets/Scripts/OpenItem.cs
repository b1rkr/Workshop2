using System;
using UnityEngine;

public class OpenItem : MonoBehaviour
{
    SpriteRenderer sr;
    public Sprite sprite1;
    public Sprite sprite2;
    public BoxCollider2D trigger;
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            sr.sprite = sprite2;
            Debug.Log("Open Item");
        }
    }
}
