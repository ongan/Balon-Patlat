using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunKontrolcu : MonoBehaviour
{
    public GameObject patlama;
    public GameObject bastanButonu;
    public GameObject oyundanCik;

    public float zamanSayaci = 60;
    int patlayanBalon = 0;
    [SerializeField]  Text zamanText, balonText;
    Button bastan;
    void Start()
    {
        balonText.text = "Balon : " + patlayanBalon;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (zamanSayaci > 0)
        {
            oyundanCik.SetActive(false);
            bastanButonu.SetActive(false);
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "Zaman : " + (int)zamanSayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position,go[i].transform.rotation);
                Destroy(go[i]);
                bastanButonu.SetActive(true);
                oyundanCik.SetActive(true);
            }
        }
    }
    public void BalonEkle()
    {
        patlayanBalon++;
        balonText.text = "Balon : " + patlayanBalon;

    }

    
}
