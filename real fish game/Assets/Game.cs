using System.Collections;
using System.Collections.Generic;
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
        ui.Bait text = "Bait: " + GameManager.Bait;
    }
}
