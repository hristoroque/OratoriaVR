using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;

    private void Start()
    {
        player.AddComponent<KeyboardControllerStrategy>();
    }
}
