using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class FishMechanic : MonoBehaviour
{
    public Text ui;

    public void Fish()
    {
        if (GameManager.Bait > 0)
        {
            GameManager.Fish += 1;
            GameManager.Bait -= 1;
        }
    }
    void Update()
    {
        ui.text = "FISH: " + GameManager.Fish;
    }
}
