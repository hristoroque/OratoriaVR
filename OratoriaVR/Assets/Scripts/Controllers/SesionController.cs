using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SesionController : Controller
{
    private PerfilController perfilController;

    private void Awake()
    {
        base.Awake();
        perfilController = GetComponent<PerfilController>();
    }

    public void GoToPerfil()
    {
        Close();
        perfilController.Show();
    }

    public void GoToExit()
    {
        Close();
        // reporteController.Show();
    }
}

