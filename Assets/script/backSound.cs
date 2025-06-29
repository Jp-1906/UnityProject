using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backSound : MonoBehaviour
{  
    public static backSound instance;
    public AudioSource suaraBS;

    public void OnEnable()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
