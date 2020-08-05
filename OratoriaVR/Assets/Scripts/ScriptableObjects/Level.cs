using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="level",menuName ="Nivel",order =1)]
public class Level : ScriptableObject
{
    public string nombre;
    public int numberOfPeople;
    public float time;
}
