using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sign : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       HideUI(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ShowUI();
        }
    }

    public GameObject ui;


    public void HideUI()
    {
        ui.SetActive(false);
    }
    public void ShowUI()
    {
        ui.SetActive(true);
    }
}
