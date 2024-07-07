using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlugController : MonoBehaviour
{
    public bool isConectedEnd = false;
    public bool isConnectedStart = false;
    //public bool pointAConected = false;
    //public bool pointBConnected = false;
    public UnityEvent OnWirePlugged;
    public Transform plugPosition;

    [HideInInspector]
    public Transform endAnchor,startAnchor;
    [HideInInspector]
    public Rigidbody endAnchorRB, startAnchorRB;
    [HideInInspector]
    public WireController wireController;

    public void OnPlugged()
    {
        OnWirePlugged.Invoke();
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        Debug.Log(other.tag);
        if (other.gameObject == endAnchor.gameObject)
        {
            isConectedEnd = true;
            endAnchorRB.isKinematic = true;
            endAnchor.transform.position = plugPosition.position;
            endAnchor.transform.rotation = transform.rotation;


            OnPlugged();
        }
        else if (other.gameObject == startAnchor.gameObject)
        {
            isConnectedStart = true;
            startAnchorRB.isKinematic = true;
            startAnchor.transform.position = plugPosition.position;
            startAnchor.transform.rotation = transform.rotation;


            OnPlugged();
        }
    }

    private void Update()
    {

        if (isConectedEnd)
        {
            endAnchorRB.isKinematic = true;
            endAnchor.transform.position = plugPosition.position;
            Vector3 eulerRotation = new Vector3(this.transform.eulerAngles.x + 90, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
            endAnchor.transform.rotation = Quaternion.Euler(eulerRotation);


        }
        else if (isConnectedStart)
        {
            startAnchorRB.isKinematic = true; //added
            startAnchor.transform.position = plugPosition.position;//added
            Vector3 eulerRotation = new Vector3(this.transform.eulerAngles.x + 90, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
            startAnchor.transform.rotation = Quaternion.Euler(eulerRotation);//added
        }

        //else if (pointAConected && pointBConnected)
        //{

        //        OnconditionsAchieved.Invoke();

        //}



    }
}
