using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbablePhysics : MonoBehaviour
{
    Rigidbody m_rigidbody;

    public void ChangePhysics()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        if(m_rigidbody == null)
        {
            Debug.Log("null ref");
            return;
        }
        m_rigidbody.useGravity = true;
        m_rigidbody.isKinematic = false;
    }
}
