using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAnim : MonoBehaviour
{
    public GameObject enemies;
    public GameObject enemies2;
    public GameObject enemies3;
    public GameObject enemies4;
    public GameObject enemies5;
    public GameObject enemies6;
    public GameObject enemies7;
    public GameObject enemies8;
    public GameObject enemies9;
    public GameObject enemies10;
    public GameObject enemies11;
    public GameObject enemies12;
    public GameObject enemies13;
    public GameObject enemies14;
    public GameObject enemies15;
    public int criancas;
    public int criancas2;
    public int criancas3;
    public int criancas4;
    public int criancas5;
    public int criancas6;
    public int criancas7;
    public int criancas8;
    public int criancas9;
    public int criancas10;
    public int criancas11;
    public int criancas12;
    public int criancas13;
    public int criancas14;
    public int criancas15;
    public bool win = false;
    public bool lose;
    public GameObject[] criancasArray;
    public GameObject[] criancasArray2;
    public GameObject[] criancasArray3;
    public GameObject[] criancasArray4;
    public GameObject[] criancasArray5;
    public GameObject[] criancasArray6;
    public GameObject[] criancasArray7;
    public GameObject[] criancasArray8;
    public GameObject[] criancasArray9;
    public GameObject[] criancasArray10;
    public GameObject[] criancasArray11;
    public GameObject[] criancasArray12;
    public GameObject[] criancasArray13;
    public GameObject[] criancasArray14;
    public GameObject[] criancasArray15;
    public float contaTempo;
    public float contaTempo2;
    public float contaTempo3;
    public float contaTempo4;
    public float contaTempo5;
    public float contaTempo6;
    public float contaTempo7;
    public float contaTempo8;
    public float contaTempo9;
    public float contaTempo10;
    public float contaTempo11;
    public float contaTempo12;
    public float contaTempo13;
    public float contaTempo14;
    public float contaTempo15;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        criancas = enemies.GetComponentsInChildren<Transform>().Length;
        criancas2 = enemies2.GetComponentsInChildren<Transform>().Length;
        criancas3 = enemies3.GetComponentsInChildren<Transform>().Length;
        criancas4 = enemies4.GetComponentsInChildren<Transform>().Length;
        criancas5 = enemies5.GetComponentsInChildren<Transform>().Length;
        criancas6 = enemies6.GetComponentsInChildren<Transform>().Length;
        criancas7 = enemies7.GetComponentsInChildren<Transform>().Length;
        criancas8 = enemies8.GetComponentsInChildren<Transform>().Length;
        criancas9 = enemies9.GetComponentsInChildren<Transform>().Length;
        criancas10 = enemies10.GetComponentsInChildren<Transform>().Length;
        criancas11 = enemies11.GetComponentsInChildren<Transform>().Length;
        criancas12 = enemies12.GetComponentsInChildren<Transform>().Length;
        criancas13 = enemies13.GetComponentsInChildren<Transform>().Length;
        criancas14 = enemies14.GetComponentsInChildren<Transform>().Length;
        criancas15 = enemies15.GetComponentsInChildren<Transform>().Length;
        if (criancas == 1)
        {

            contaTempo += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas in criancasArray)
            {
                if (contaTempo >= 1f)
                {
                    win = false;
                    if (contaTempo >= 5f)
                    {
                        criancas.SetActive(true);
                    }

                    //transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime); 
                    FindObjectOfType<AndaPersonagem>().anda = true;
                    //anim.SetBool("Anda", false); 
                }
            }
        }
        if (criancas2 == 1)
        {
            
            contaTempo2 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas2 in criancasArray2)
            {
                if (contaTempo2 >= 1f)
                {
                    
                    win = false;
                    if (contaTempo2 >= 5f)
                    {
                        criancas2.SetActive(true);
                    }

                    //transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime); 
                    FindObjectOfType<AndaPersonagem>().anda = true;
                    //anim.SetBool("Anda", false); 
                }
            }
        }
        if (criancas3 == 1)
        {
            contaTempo3 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas3 in criancasArray3)
            {
                if(contaTempo3 >= 1f)
                {
                    win = false;
                    if (contaTempo3 >= 5f)
                    {
                        
                        criancas3.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }
                
            }
        }
        if (criancas4 == 1)
        {
            contaTempo4 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas4 in criancasArray4)
            {
                if (contaTempo4 >= 1f)
                {
                    win = false;
                    if (contaTempo4 >= 5f)
                    {

                        criancas4.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas5 == 1)
        {
            contaTempo5 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas5 in criancasArray5)
            {
                if (contaTempo5 >= 1f)
                {
                    win = false;
                    if (contaTempo5 >= 5f)
                    {

                        criancas5.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas6 == 1)
        {
            contaTempo6 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas6 in criancasArray6)
            {
                if (contaTempo6 >= 1f)
                {
                    win = false;
                    if (contaTempo6 >= 5f)
                    {

                        criancas6.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas7 == 1)
        {
            contaTempo7 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas7 in criancasArray7)
            {
                if (contaTempo7 >= 1f)
                {
                    win = false;
                    if (contaTempo7 >= 5f)
                    {

                        criancas7.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas8 == 1)
        {
            contaTempo8 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas8 in criancasArray8)
            {
                if (contaTempo8 >= 1f)
                {
                    win = false;
                    if (contaTempo8 >= 5f)
                    {

                        criancas8.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas9 == 1)
        {
            contaTempo9 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas9 in criancasArray9)
            {
                if (contaTempo9 >= 1f)
                {
                    win = false;
                    if (contaTempo9 >= 5f)
                    {

                        criancas9.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas10 == 1)
        {
            contaTempo10 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas10 in criancasArray10)
            {
                if (contaTempo10 >= 1f)
                {
                    win = false;
                    if (contaTempo10 >= 5f)
                    {

                        criancas10.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas11 == 1)
        {
            contaTempo11 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas11 in criancasArray11)
            {
                if (contaTempo11 >= 1f)
                {
                    win = false;
                    if (contaTempo11 >= 5f)
                    {

                        criancas11.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas12 == 1)
        {
            contaTempo12 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas12 in criancasArray12)
            {
                if (contaTempo12 >= 1f)
                {
                    win = false;
                    if (contaTempo12 >= 5f)
                    {

                        criancas12.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas13 == 1)
        {
            contaTempo13 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas13 in criancasArray13)
            {
                if (contaTempo13 >= 1f)
                {
                    win = false;
                    if (contaTempo13 >= 5f)
                    {

                        criancas13.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas14 == 1)
        {
            contaTempo14 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas14 in criancasArray14)
            {
                if (contaTempo14 >= 1f)
                {
                    win = false;
                    if (contaTempo14 >= 5f)
                    {

                        criancas14.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
        if (criancas15 == 1)
        {
            contaTempo15 += Time.deltaTime;
            EndRound();
            foreach (GameObject criancas15 in criancasArray15)
            {
                if (contaTempo15 >= 1f)
                {
                    win = false;
                    if (contaTempo15 >= 5f)
                    {

                        criancas15.SetActive(true);
                    }
                    FindObjectOfType<AndaPersonagem>().anda = true;
                }

            }
        }
    }
    public void EndRound()
    {
        win = true;
        FindObjectOfType<ControlaTimer>().timeLeft = FindObjectOfType<ControlaTimer>().maxTime;
    }
}
