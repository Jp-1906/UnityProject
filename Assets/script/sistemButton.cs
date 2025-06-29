using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sistemButton : MonoBehaviour
{
    public GameObject btnOff;
    public GameObject btnOn;

    // Start is called before the first frame update
    void Start()
    {
        btnOn.SetActive(true);
        btnOff.SetActive(false);
    }

    public void Mute()
    {
        backSound.instance.suaraBS.Pause();
            btnOff.SetActive(true);
            btnOn.SetActive(false);
    }

    public void Aktif()
    {
         backSound.instance.suaraBS.UnPause();
            btnOff.SetActive(false);
            btnOn.SetActive(true);
    }
}       
    // Update is called once per frame
    // void Update()
    // {
        
    // }

