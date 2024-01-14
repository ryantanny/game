using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;

    public void Increment()
    {
        GameManager.Bait += 1;
    }
    void Update()
    {
        ui.text = "BAIT: " + GameManager.Bait;
    }
}
