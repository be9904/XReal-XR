using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SpawnCube : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject grabbableCube;
    [SerializeField] Transform grabPos;

    bool isHovered = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        EventSystem.current.SetSelectedGameObject(null);
        Instantiate(grabbableCube, grabPos.position, Quaternion.identity);
    }

    public void IsHovered(bool _isHovered) => isHovered = _isHovered;

    void Update()
    {
        if (isHovered)
            Debug.Log("Hover Entered");
        else
            Debug.Log("Hover Exited");
    }
}
