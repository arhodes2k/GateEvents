using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Coin : MonoBehaviour
{
    [SerializeField] float speed = 360f;

// creating the event
    public UnityEvent PowerUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime * Vector3.right);
    }

    private void OnTriggerEnter(Collider other){
        PowerUp.Invoke();
    
    }
}
