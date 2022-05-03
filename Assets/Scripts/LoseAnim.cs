using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseAnim : MonoBehaviour
{
    private Animator anim;
    GameObject inimigos;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    public void LoseRound()
    {
        anim.SetBool("Perde", true);
        FindObjectOfType<ControlaAnim>().win = false;
        //GameObject.FindObjectOfType<TouchVerifica>().enabled = false;
        //GameObject.FindObjectOfType<TouchVerifica>().enabled = false;
        FindObjectOfType<ControlaAnim>().lose = true;
        if (FindObjectOfType<ControlaAnim>().lose == true)
        {
            //inimigos = GameObject.Find("Inimigos"); 
            //inimigos.GetComponentInChildren<TesteTeste>().enabled = false; 
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
        Time.timeScale = 0.5f;
    }
    public void TrocaCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
