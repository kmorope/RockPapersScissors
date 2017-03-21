using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioSource _audioSource;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("musica") == 1)
        {
            if (!_audioSource.isPlaying)
                _audioSource.Play();
        }
        else
	    {
            _audioSource.Stop();
        }
	}

    void Update()
    {
        if (PlayerPrefs.GetInt("musica") == 1)
        {
            if (!_audioSource.isPlaying)
                _audioSource.Play();
        }
        else
        {
            if(_audioSource.isPlaying)
                _audioSource.Stop();
        }
    }

}
