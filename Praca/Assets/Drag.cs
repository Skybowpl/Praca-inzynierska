using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rg;

    private void OnMouseDrag()
    {
        rg.MovePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    private void OnMouseUp()
    {
        rg.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
    }
    private void OnMouseDown()
    {
        rg.constraints = ~(RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            rg.constraints = ~(RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY);
        }

    }
}
