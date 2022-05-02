using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WristUI : MonoBehaviour
{
    [SerializeField] Animator m_Animator;
    [SerializeField] GameObject Panel;

    bool isOpen;

    private void Start() => m_Animator = Panel.GetComponent<Animator>();

    public void OpenPanel()
    {
        if(Panel != null && m_Animator != null)
        {
            isOpen = m_Animator.GetBool("OpenUI");
            m_Animator.SetBool("OpenUI", !isOpen);
        }
    }
}
