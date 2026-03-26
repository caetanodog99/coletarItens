using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItensManager : MonoBehaviour
{
    public int itensColetados;
    [SerializeField]public TextMeshProUGUI itensTXT;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("item"))
        {
            //Debug.Log("bateu no collider do item");
            itensColetados++;
            itensTXT.text = itensColetados.ToString();

            Destroy(other.gameObject);
        }

    }
}
