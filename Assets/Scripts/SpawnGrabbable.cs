using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrabbable : MonoBehaviour
{
    Rigidbody m_rigidbody;
    bool isGrabbed = false;

    public void ChangePhysics()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        if(m_rigidbody == null)
        {
            Debug.Log("Null Rigidbody");
            return;
        }
        m_rigidbody.useGravity = true;
        m_rigidbody.isKinematic = false;
    }
}
