using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int randomT;
    // Start is called before the first frame update
    void Start()
    {
        randomT = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
       //i = 6;
       i++;
       Debug.Log(gameObject.name + ":" + i); 

       if (gameObject.CompareTag("Red") && i==100){
        gameObject.SetActive(false);
       }
       else if (gameObject.CompareTag("Blue") && i >= randomT){
        if (rend!=null){
            rend.enabled = false;
        }
       }
    }
}
