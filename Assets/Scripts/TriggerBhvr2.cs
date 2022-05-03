using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBhvr2 : MonoBehaviour
{
    public GameObject cenario2;
    public GameObject cenario2fantasma;


    
    public void OnTriggerExit(Collider other)
    {
        //cenario2.transform.Translate(new Vector3(0, 0, pivot2.transform.position.z + 18.069f / 2f));
        //cenario2.transform.Translate(cenario2fantasma.transform.position, Space.Self);
        FindObjectOfType<AndaPersonagem>().anda = false;
        FindObjectOfType<ControlaAnim>().contaTempo2 = 0f;

    }
    
}
