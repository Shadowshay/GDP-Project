using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPopup : MonoBehaviour
{
    public GameObject PopupPanel;

    public void OpenPanel()
    {
        if (PopupPanel != null)
        {
            PopupPanel.SetActive(true);
        }
    }
}
