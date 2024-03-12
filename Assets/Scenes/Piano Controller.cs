using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoController : MonoBehaviour
{
    AudioSource _do, _re, _mi , _fa, _son, _la, _si;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");

       _do = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
       _re = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
       _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
       _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
       _son = GameObject.FindWithTag("son").GetComponent<AudioSource>();
       _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
       _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            _do.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _re.Play();
        }
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            _mi.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _fa.Play();
        }
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            _son.Play();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _la.Play();
        }
        if (Input.GetKeyDown(KeyCode.F)) 
        { 
            _si.Play();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }   
}
