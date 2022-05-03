using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBhvr3 : MonoBehaviour
{
    public GameObject cenarioPaizao;
    public GameObject cenario3fantasma;

    public void OnTriggerExit(Collider other)
    {
        //cenario3.transform.Translate(new Vector3(0, 0, pivot3.transform.position.z + 18.069f + 18.069f/2f));
        //cenario3.transform.Translate(cenario3fantasma.transform.position, Space.Self);
        
        FindObjectOfType<AndaPersonagem>().anda = false;
        FindObjectOfType<ControlaAnim>().contaTempo3 = 0f;
        FindObjectOfType<ResetCenario>().Reseta();
    }
}
