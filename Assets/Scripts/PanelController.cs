using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour {

    public Button _music;

    public Button _audio;

    // Use this for initialization
    void Start ()
	{
	    HidePanel(); 
    }

    public void ShowPanel()
    {
        this.gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        this.gameObject.SetActive(false);
    }

    public void DisableMusic()
    {
        if (PlayerPrefs.GetInt("musica") == 1)
        {
            PlayerPrefs.SetInt("musica",0);
            var image = _music.GetComponent(typeof(Image)) as Image;
            image.sprite = Resources.Load("Images/Gui/Gui/Button/No" , typeof(Sprite)) as Sprite;
        }
        else if (PlayerPrefs.GetInt("musica") == 0)
        {
            PlayerPrefs.SetInt("musica", 1);
            var image = _music.GetComponent(typeof(Image)) as Image;
            image.sprite = Resources.Load("Images/Gui/Gui/Button/Yes", typeof(Sprite)) as Sprite;
        }
    }

    public void DisableAudio()
    {
        if (PlayerPrefs.GetInt("audio") == 1)
        {
            PlayerPrefs.SetInt("audio", 0);
            var image = _audio.GetComponent(typeof(Image)) as Image;
            image.sprite = Resources.Load("Images/Gui/Gui/Button/No", typeof(Sprite)) as Sprite;
        }
        else if (PlayerPrefs.GetInt("audio") == 0)
        {
            PlayerPrefs.SetInt("audio", 1);
            var image = _audio.GetComponent(typeof(Image)) as Image;
            image.sprite = Resources.Load("Images/Gui/Gui/Button/Yes", typeof(Sprite)) as Sprite;
        }
    }
}
