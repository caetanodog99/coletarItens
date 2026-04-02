using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class painelScore : MonoBehaviour
{
    [SerializeField]public TextMeshProUGUI textoTela;

    void Update()
    {
        AtualizarPlacar();
    }

    void AtualizarPlacar()
    {
        string placar = "=== PLACAR ===\n";
        NetworkObject[] todosObjetos = FindObjectsOfType<NetworkObject>();
        int numeroPlayer = 1;

        foreach (NetworkObject networkObj in todosObjetos)
        {
            movimentControl player = networkObj.GetComponent<movimentControl>();

            if (player != null)
            {
                string marcador = networkObj.HasInputAuthority ? " (VOCÊ)" : "";
                placar += $"Player {numeroPlayer}{marcador}: {player.Score} pontos\n";
                numeroPlayer++;
            }
        }

        textoTela.text = placar;
    }
}