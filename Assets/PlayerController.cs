using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] float speed = 1f;

   [SerializeField] GameObject Coin;
   GameObject instance;
     bool bCoin = false; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
          
        Debug.Log("bCoin is " + bCoin);
            if (bCoin == false){
                instance = (GameObject) Instantiate(Coin, transform.position, Coin.transform.rotation);
                Debug.Log("should be uhhh right here");
                bCoin = !bCoin;
         } else {
                Destroy(instance);
                bCoin = !bCoin;
         }
        }
        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        
        transform.Translate(speed * hor * Time.deltaTime, 0, speed * vert * Time.deltaTime);
        // can also use: transform.Translate(speed * Vector3.right + speed* Vector3.forward);
        
    }
}
