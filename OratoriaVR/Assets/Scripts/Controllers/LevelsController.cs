using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsController : Controller
{
    private PerfilController perfilController;
    private PlayController playController;
    private SesionController sesionController;
    void Awake()
    {
        base.Awake();
        perfilController = GetComponent<PerfilController>();
        playController = GetComponent<PlayController>();
        sesionController = GetComponent<SesionController>();
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
        //playController.Show();
        sesionController.Show();    
    }
    public void GoToSesionController()
    {
        Close();
        sesionController.Show();
    }
}
