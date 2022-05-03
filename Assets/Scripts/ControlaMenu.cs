using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject[] inimigos1;
    // Update is called once per frame
    void Update()
    {
        //se o menu esta ativo, desativa timer e matar inimigo
        if (menu.activeInHierarchy)
        {
            FindObjectOfType<ControlaTimer>().enabled = false;
            foreach (GameObject inimigo in inimigos1)
            {
                inimigo.GetComponent<CapsuleCollider>().enabled = false;
            }

            //FindObjectOfType<TouchVerifica>().enabled = false;
        }
        else if(!menu.activeInHierarchy && GameObject.FindObjectOfType<LoseAnim>().GetComponent<Animator>().GetBool("Perde") == false)
        {
            FindObjectOfType<ControlaTimer>().enabled = true;
            foreach (GameObject inimigo in inimigos1)
            {
                inimigo.GetComponent<CapsuleCollider>().enabled = true;
            }

            // FindObjectOfType<TouchVerifica>().enabled = true;
        }

        

    }
    public void Play()
    {
        
        menu.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitou!");
    }
}
