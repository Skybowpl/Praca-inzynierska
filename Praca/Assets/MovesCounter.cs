using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovesCounter : MonoBehaviour
{
    [SerializeField] private int moves;
    [SerializeField] private TextMeshProUGUI textMeshPro;

    private void Start()
    {
        textMeshPro.text = Convert.ToString(moves);
    }
    public int getMoves()
    {
        return moves;
    }
    public void removeMoves()
    {
        moves--;
        textMeshPro.text = Convert.ToString(moves);
    }

}
