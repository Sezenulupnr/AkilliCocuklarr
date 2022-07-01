using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pause : MonoBehaviour
{
    public GameObject ButtonPanel;
    private static bool PanelActive=false;
    public GameObject[] Levels;
    public GameObject FinishPanel;
    public int Level=0;

private static Pause instance = null;
    public static Pause Instance {
        get {
            return instance;
        }
    }

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        }

    PlayerPrefs.SetInt("LevelNo",Level);
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void LevelGec() {
        if (Level < Levels.Length) {
            Levels[Level].SetActive(false);
            Level++;
            Levels[Level].SetActive(true);
            FinishPanel.SetActive(false);
        }
        else{
            Level=0;
            Levels[Level].SetActive(false);
            Level++;
            Levels[Level].SetActive(true);
            FinishPanel.SetActive(false);
        }
    }

    public static bool isPaused; // Varsayılan değeri false..
    // static olduğu için diğer classlardan Pause.isPause şeklinde çağırılabilir.
    
    public AudioSource PauseAudio;
    public AudioSource ContinueAudio;

 void Update()
    {
        if (Input.GetMouseButtonDown(1)) // P tuşuna basıldığında
        {
            if(PanelActive==false){
           ButtonPanel.SetActive(true);
           PanelActive=true;
            }
            else if(PanelActive==true){
           ButtonPanel.SetActive(false);
           PanelActive=false;
            }
            Level=PlayerPrefs.GetInt("LevelNo");
        }}
    public void pause()
    {
        
            if ( isPaused==false ) // Durdurulmamışsa durdur
            {
            
                StartCoroutine("_pause");
                
            }
    }
        
    public IEnumerator _pause()
    {
        
         PauseAudio.Play();
          Time.timeScale = 0;
                isPaused = true;
                Debug.Log("Oyun Durduruldu");
               
            yield return new WaitForSeconds(1.0f);
           
    } 

    public void continueGame()
    {
        
        if (isPaused) // Oyun durdurulmuşsa devam ettir
            {

                StartCoroutine("_continueGame");
                
            }
            
             ButtonPanel.SetActive(false);
             PanelActive=false;
    }
     
    public IEnumerator _continueGame()
    {
         
         ContinueAudio.Play();
         Time.timeScale = 1;
                isPaused = false;
                Debug.Log("Oyun Başlatıldı");
            yield return new WaitForSeconds(1.0f);
            
               
    } 
    public void Panelactive()
    {
        ButtonPanel.SetActive(true);
        PanelActive=true;

    }

}