using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguraPlayer : MonoBehaviour
{
    public void OnTriggerExit(Collider other)
    {
        FindObjectOfType<AndaPersonagem>().anda = false;
        FindObjectOfType<ControlaAnim>().contaTempo = 0f;
    }
}
