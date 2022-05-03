using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBhvr : MonoBehaviour
{
    //public GameObject cenario1;
    public GameObject cenarioPaizao;
    public GameObject cenarioPaizao2;
    //public GameObject cenario1fantasma;
    public float xMeu, yMeu, zMeu;
    public float xMeu2, yMeu2, zMeu2;
    

    public void OnTriggerExit(Collider other)
    {
        //cenario1.transform.Translate(new Vector3(0, 0, pivot.transform.position.z - 18f), Space.World);
        //cenario1.transform.Translate(cenario1fantasma.transform.position, Space.Self);
        cenarioPaizao.transform.Translate(new Vector3(xMeu, yMeu, zMeu));
        cenarioPaizao2.transform.Translate(new Vector3(xMeu2, yMeu2, zMeu2));
        FindObjectOfType<AndaPersonagem>().anda = false;
        FindObjectOfType<ControlaAnim>().contaTempo = 0f;
    }
}
