using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrolcu : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrolcu oyunKontrolcuScripti;

    private void Start()
    {
        oyunKontrolcuScripti = GameObject.Find("_Scripts").GetComponent<OyunKontrolcu>();
    }
    private void OnMouseDown()
    {
        GameObject go;
        go = Instantiate(patlama, this.transform.position, this.transform.rotation) as GameObject;
        Destroy(this.gameObject);
        if (go.activeInHierarchy)
        {
            Destroy(go, 0.267f);
        }
        oyunKontrolcuScripti.BalonEkle();
    }
      
    
}
