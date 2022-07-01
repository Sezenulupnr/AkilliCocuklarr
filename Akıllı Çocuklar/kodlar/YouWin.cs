using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    public GameObject YouWinPanel;
    public AudioSource winAudio;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" );
        {
            YouWinPanel.SetActive(true);
            winAudio.Play();
            Time.timeScale = 0f;
        }
    }
}
