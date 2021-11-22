using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopup : MonoBehaviour
{
    public GameObject PopupPanel;

    public void ClosePanel()
    {
        if (PopupPanel != null)
        {
            PopupPanel.SetActive(false);
        }
    }
}
