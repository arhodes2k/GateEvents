using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gate : MonoBehaviour
{
    Animator anim;
    GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
         coin = GameObject.FindGameObjectWithTag("coin");

        if(coin != null){

            //getting the reference to the object, adding a listener to the event, and in () the reaction to that event being called.
            coin.GetComponent<Coin>().PowerUp.AddListener(OnPowerUp);
        }
    }

    private void OnTriggerEnter(Collider other){
        anim.Play("open");
    }

    private void OnTriggerExit(Collider other){
        anim.Play("close");
    }

    public void OnPowerUp(){
        anim.Play("open");
    }
}
