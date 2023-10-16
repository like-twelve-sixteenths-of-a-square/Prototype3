using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXmakeNoise : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip vineBoomSFX;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Make boom when schuute very g ood yes yes (Please do not dock my grade for something like this I'm just trying to entertain myself.)
        if (Input.GetKeyDown(KeyCode.Q) && !audioSource.isPlaying)
        {
            audioSource.PlayOneShot(vineBoomSFX);

        }


        //Noise Reckoning (Not a good idea)
        if (Input.GetKey(KeyCode.P))
        {
            audioSource.PlayOneShot(vineBoomSFX);
        }
    }
}
