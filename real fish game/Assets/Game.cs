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
    public void Fish()
    {
        if(GameManager.Bait > 0)
        {
            GameManager.Fish += 1;
            GameManager.Bait -= 1;
        }
    }
    void Update()
    {
        ui.text = "BAIT: " + GameManager.Bait;
        ui.text = "FISH: " + GameManager.Fish;
    }
}
