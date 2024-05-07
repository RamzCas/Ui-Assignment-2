using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveController : MonoBehaviour /*IBeginDragHandler, IDragHandler, IEndDragHandler*/
{
    Vector3 offset;
    Collider2D collider2D;
    public string TagPoint = "DropPoint";

    private void OnMouseDown()
    {
        offset = transform.position - MousWorldPos();
    }

    private void OnMouseDrag()
    {
        transform.position = MousWorldPos() + offset;
    }

    //private void OnMouseUp()
    //{
    //    collider2D.enabled = false;
    //    var rayOrigin = Camera.main.transform.position;
    //    var rayDirection = MousWorldPos() - Camera.main.transform.position;
    //    RaycastHit2D hitInfo;

    //    if (hitInfo = Physics2D.Raycast(rayOrigin, rayDirection))
    //    {
    //        if (hitInfo.transform.tag == TagPoint)
    //        {
    //            transform.position = hitInfo.transform.position + new Vector3(0, 0, -0.01f);
    //        }
    //    }

    //    collider2D.enabled = true;
    //}


    Vector3 MousWorldPos()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);

     }
        //public void OnBeginDrag(PointerEventData eventData)
        //{
        //    Debug.Log("DragBegin");
        //}

        //public void OnDrag(PointerEventData eventData)
        //{
        //    Debug.Log("Dragging");
        //    transform.position = Input.mousePosition;
        //}

        //public void OnEndDrag(PointerEventData eventData)
        //{
        //    Debug.Log("DragStop");
        //}
 }
