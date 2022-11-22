using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private int itemNumberSpawn;
    [SerializeField] private GameObject obj;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MarkersManager>())
        {
            for (int i = 0; i < itemNumberSpawn; i++)
            {
                GameObject.FindObjectOfType<SnakeManager>
                    ().AddBodyPart(obj);
            }
        }
        Destroy(gameObject);
    }
}
