﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange) {
            if (Input.GetKeyDown(interactKey)) {
                interactAction.Invoke();
                Debug.Log("ANSWERING PHONE");
            }
        }
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.CompareTag("Player")) {
            isInRange = true;
            collision.gameObject.GetComponent<PlayerManager>().NotifyPlayer();
            Debug.Log("Player now in range");
        }
    }

    private void OnTriggerExit(Collider collision) {
        if (collision.gameObject.CompareTag("Player")) {
            isInRange = false;
            collision.gameObject.GetComponent<PlayerManager>().DeNotifyPlayer();
            Debug.Log("Player now not in range");
        }
    }
}
