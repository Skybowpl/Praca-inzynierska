using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rg;
    [SerializeField] private GameObject numberofMoves;
    private bool canKill=true;

    private void OnMouseDrag()
    {
        if (numberofMoves.GetComponent<MovesCounter>().getMoves() > 0)
        {
            rg.MovePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
            
    }

    private void OnMouseUp()
    {
        if (numberofMoves.GetComponent<MovesCounter>().getMoves() > 0)
        {
            rg.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
            numberofMoves.GetComponent<MovesCounter>().removeMoves();
        }
    }
    private void OnMouseDown()
    {
        if (numberofMoves.GetComponent<MovesCounter>().getMoves() > 0)
        {
            canKill = false;
            rg.constraints = ~(RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY);
        }
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            canKill = true;
            rg.constraints = ~(RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY);
        }

    }
    public bool getCanKill()
    {
        return canKill;
    }
}
