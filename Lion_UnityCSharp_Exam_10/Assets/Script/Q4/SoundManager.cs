using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource aud;
    [Header("背景音樂")]
    public AudioClip backgroundsound;
    [Header("終點音效")]
    public AudioClip sound;

    public Q4_Runner player;




    void Start()
    {
        aud = GetComponent<AudioSource>();
        aud.PlayOneShot(backgroundsound,1);
        player.GetEnd += EndSound;
    }
    
    public void EndSound()
    {
       aud.PlayOneShot(sound, 1);
    }

}
