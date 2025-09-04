using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class CheckPosMosquito : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sound;
    [SerializeField]
    private SuckingBlood SuckingBlood;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SuckingBlood.Suckable = true;
        Debug.Log("They are within sucking range");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        SuckingBlood.Suckable = false;
        Debug.Log("They are out of sucking range");
    }
    void Update()
    {
        if (SuckingBlood.Suckable)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = sound;
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
