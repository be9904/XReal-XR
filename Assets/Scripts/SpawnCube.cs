using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SpawnCube : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject grabbableCube;
    [SerializeField] Transform grabPos;

    public void OnPointerDown(PointerEventData eventData)
    {
        EventSystem.current.SetSelectedGameObject(null);
        Instantiate(grabbableCube, grabPos.position, Quaternion.identity);
    }
}
