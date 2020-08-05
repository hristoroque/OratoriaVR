using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    [SerializeField] Audio audioPrefab;

    private void Awake()
    {
        Audio audio = Instantiate(audioPrefab,Vector3.zero,Quaternion.identity);
        Locator.Provide(audio);
    }
}
