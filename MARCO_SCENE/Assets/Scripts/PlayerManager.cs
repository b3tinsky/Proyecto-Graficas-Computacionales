using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public bool answeredPhone = false;
    public GameObject text;

    void Start()
    {
     text.SetActive(false);   
    }
    public void answerPhone() {
        answeredPhone = true;
    }
    public void NotifyPlayer() {
        text.SetActive(true);
    }
    public void DeNotifyPlayer() {
        text.SetActive(false);
    }
}
