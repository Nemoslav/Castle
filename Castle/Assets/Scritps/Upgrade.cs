using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Upgrade/New upgrade", fileName = "New Upgrade", order = 51)]
public class Upgrade : ScriptableObject
{
    public Sprite icon;
    public GameObject prefab;
    public int cost;
}
