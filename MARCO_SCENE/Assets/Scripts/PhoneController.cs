using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneController : MonoBehaviour
{
    public AudioSource DeadLine;
    public ParticleSystem Rain;
    // private ParticleSystem Rain;
    // Start is called before the first frame update
    // void Start() {
    //     Rain = GetComponent<ParticleSystem>();
    // }
    public void AnswerPhone() {
        StartCoroutine(HangUp());
        // var main = Rain.main;

        IEnumerator HangUp() {
            
                Rain.startColor = new Color(1, 0, 0, 1.0f);
                yield return new WaitForSeconds(14);
                DeadLine.enabled = true;
                yield break;
        }
    }
}
