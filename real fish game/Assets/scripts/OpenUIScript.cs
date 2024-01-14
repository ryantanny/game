using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUIScript : MonoBehaviour
{
    public GameObject uiToOpen;

    public void OpenUI()
    {
        uiToOpen.SetActive(true);
    }

    
    public void CloseUI()
    {
        uiToOpen.SetActive(false);
    }
}
