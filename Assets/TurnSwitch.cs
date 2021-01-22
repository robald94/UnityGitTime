using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnSwitch : MonoBehaviour
{
    public bool swapped = false;

    private Vector3 m1CurrentPosition;
    private Vector3 m2CurrentPosition;

    [SerializeField]
    private List<Vector3> markerCurrentPosition;
    public List<GameObject> players;
    public List<Button> markers;
    void Start()
    {
        //m1CurrentPosition = markers[0].GetComponent<RectTransform>().position;
        //m2CurrentPosition = markers[1].GetComponent<RectTransform>().position;

        //markerCurrentPosition[0] = markers[0].GetComponent<RectTransform>().position;
        //markerCurrentPosition[1] = markers[1].GetComponent<RectTransform>().position;
        //markerCurrentPosition[2] = markers[2].GetComponent<RectTransform>().position;

        foreach (Button i in markers)
        {
            markerCurrentPosition.Add(i.GetComponent<RectTransform>().position);
        }


        Debug.Log(swapped);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetColorFromPlayer();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwapPosition();
        }
    }

    void GetColorFromPlayer()
    {
        markers[0].image.color = players[0].GetComponent<MeshRenderer>().material.color;
        markers[1].image.color = players[1].GetComponent<MeshRenderer>().material.color;
        markers[2].image.color = players[2].GetComponent<MeshRenderer>().material.color;

    }

    void SwapPosition()
    {
        if(swapped == false)
        {

            Debug.Log("Swap");
            //markers[0].GetComponent<RectTransform>().position = m2CurrentPosition;
            //markers[1].GetComponent<RectTransform>().position = m1CurrentPosition;

            markerCurrentPosition[0] = markerCurrentPosition[2];
            markerCurrentPosition[2] = markerCurrentPosition[1];
            markerCurrentPosition[1] = markerCurrentPosition[0];

            Debug.Log(swapped);
            swapped = true;
        }
        else
        {
            
            swapped = false;
        }
    }
}
