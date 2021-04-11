using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLookAt : MonoBehaviour
{
    public GameObject TargetObject;

    // Update is called once per frame
    void Update()
    {
        if(null != TargetObject)
        {
            this.transform.LookAt(TargetObject.transform);
        }
    }
}
