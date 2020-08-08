using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllersLoader : MonoBehaviour
{
    [SerializeField] Controller defaultController;
    // Start is called before the first frame update
    void Start()
    {
        defaultController.Show();
    }
}
