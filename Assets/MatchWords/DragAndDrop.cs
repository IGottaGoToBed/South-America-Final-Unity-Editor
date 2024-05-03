using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{
    Vector3 originalPosition;
    bool drag = true;
    public bool correct = false;
    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        
    }


    public void Drag()
    {
        if (drag == true)
        {
            gameObject.transform.position = Input.mousePosition;
        }
        else
        {
            print("NotDragging");
        }
        //GameObject.Find("Image").transform.position = Input.mousePosition;
        //print("Dragging" + gameObject.name);
    }



    public void Drop()
    {
        checkMatch();
    }



    public void checkMatch()
    {
        //GameObject ph1 = GameObject.Find("PH1");
        //GameObject img = GameObject.Find("Image");

        GameObject img = gameObject;
        string tag = gameObject.tag;
        GameObject ph1 = GameObject.Find("PH" + tag);

        float distance = Vector3.Distance(ph1.transform.position, img.transform.position);
        if (distance <= 50)
        {
            snap(img, ph1);
            correct = true;
        }
        else
        {
            moveBack();
        }
    }



    public void moveBack()
    {
        transform.position = originalPosition;
    }



    public void snap(GameObject img, GameObject ph1)
    {
        img.transform.position = ph1.transform.position;
        drag = false;
    }

    public void initCardPosition()
    {
        originalPosition = transform.position;
    }
}
