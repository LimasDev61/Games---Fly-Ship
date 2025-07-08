using TMPro;
using UnityEngine;

public class musicPlayer : MonoBehaviour

{
    public AudioClip[] musicClips;

    public TMP_Text musicName;

    private AudioSource audioSourcer;

    private int lastClipIndex = -1;

    void Start()
    {
        audioSourcer = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!audioSourcer.isPlaying)
        {
            PlayRandomMusic();
        }
    }

    public void PlayRandomMusic()
    {
        int newIndex = Random.Range(0, musicClips.Length);
        while (musicClips.Length > 1 && newIndex == lastClipIndex)
        {
            newIndex = Random.Range(0, musicClips.Length);
        }

        lastClipIndex = newIndex;
        audioSourcer.clip = musicClips[newIndex];
        audioSourcer.Play();

        if (musicName != null)
        {
            musicName.text = "Tocando: " + audioSourcer.clip.name;
        }

    }
    
}
