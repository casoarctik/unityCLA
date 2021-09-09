using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
    public int scene;
    public string message;
    public Text infos;
    public Button yes;
    public Button no;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            infos.text = message;
            infos.gameObject.SetActive(true);
            yes.gameObject.SetActive(true);
            no.gameObject.SetActive(true);
        }
        
    }

    public void loadSceneAfterClickYes()
    {
        infos.text = "[none]";
        infos.gameObject.SetActive(false);
        yes.gameObject.SetActive(false);
        no.gameObject.SetActive(false);
        SceneManager.LoadScene(scene);
    }

    public void abortProcessAfterClickNo()
    {
        infos.text = "[none]";
        infos.gameObject.SetActive(false);
        yes.gameObject.SetActive(false);
        no.gameObject.SetActive(false);
    }



}
