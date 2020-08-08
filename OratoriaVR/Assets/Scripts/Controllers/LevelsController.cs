using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsController : Controller
{
    private PerfilController perfilController;
    private PlayController playController;

    void Awake()
    {
        base.Awake();
        perfilController = GetComponent<PerfilController>();
        playController = GetComponent<PlayController>();
    }
    public void GoToPerfilController()
    {
        Close();
        perfilController.Show();
    }
    public void GoToLevel(Level level)
    {
        Debug.Log("Going to Level 1");
        Close();
        playController.Show();
    }
}
