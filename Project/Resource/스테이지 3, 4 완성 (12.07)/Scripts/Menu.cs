using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
  public static Menu instance;

    public GameObject go;

    public string call_sound;
    public string cancel_sound;


    public bool activated;

    public void Exit(){
      Application.Quit();
    }
    public void conitnue(){
      activated = false;
      go.SetActive(false);
     // theOrder.Move();
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    /*
    // Update is called once per frame/*
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape)){
        activated=!activated;
        if(activated)
        {
          theOrder.NotMove();

          go.SetActive(true);
        }
        else {
          theOrder.Move();

          go.SetActive(false);
        }
      }

    }*/
}
