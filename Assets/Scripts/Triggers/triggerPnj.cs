using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerPnj : MonoBehaviour
{
    public string message;
    public Text infos;
    public Button ok;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            infos.text = message;
            infos.gameObject.SetActive(true);
            ok.gameObject.SetActive(true);
        }
        
    }

    public void quitMessageAfterClickOK()
    {
        infos.text = "[none]";
        infos.gameObject.SetActive(false);
        ok.gameObject.SetActive(false);
    }
}
