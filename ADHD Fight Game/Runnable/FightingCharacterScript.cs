using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FightingCharacterScript : MonoBehaviour
{
    public KeyCode attackKey;

    public GameObject characterOBJ;
    Animator controllerANIM;

    public bool isBlocking;

    
    // Start is called before the first frame update
    void Start()
    {

        controllerANIM = characterOBJ.GetComponent<Animator>();
        isBlocking = false;               
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(attackKey))
        {
            Attack1();
        }
       
        if(Input.GetButton("Fire2"))
        {
            isBlocking = true;
            controllerANIM.SetBool("Blocking", isBlocking);
        }
        if (Input.GetButtonUp("Fire2"))
        {
            isBlocking = false;
            controllerANIM.SetBool("Blocking", isBlocking);
        }

    }

    [ContextMenu("Attack 01")]
    public void Attack1()
    {
        controllerANIM.SetTrigger("Punching");
        isBlocking = false;
        controllerANIM.SetBool("Blocking", isBlocking);
    }

    public void SetBlocking()
    {
       if(isBlocking)
        {
            isBlocking = false;
        }
       else if (!isBlocking)
        {
            isBlocking = true;
        }

        controllerANIM.SetBool("Blocking", isBlocking);
    }
}