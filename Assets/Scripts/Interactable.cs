using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{

    public abstract void Interact();

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("RightHand Controller"))
        {

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
