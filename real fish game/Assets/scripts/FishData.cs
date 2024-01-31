using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum FishType
{
    Tilapia,
    Barramundi,
    Seabass,
}

[System.Serializable]
public class FishData
{
    public FishType type;
    public string name;
    public float size;
}
