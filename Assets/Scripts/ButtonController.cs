using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    public void PlayScene(string scene)
    {
        if (PlayerPrefs.GetInt("audio") == 1)
            this.GetComponent<AudioSource>().Play();
        SceneChange(scene);
    }

    private void SceneChange(string scene)
    {
        SceneLoader.LoadScene(scene);
    }

}
