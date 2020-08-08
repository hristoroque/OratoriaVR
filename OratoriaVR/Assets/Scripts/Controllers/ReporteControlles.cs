using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReporteControlles : Controller
{
    PerfilController perfilController;
    void Awake()
    {
        base.Awake();
        perfilController = GetComponent<PerfilController>();
    }
    public void GoToPerfilController()
    {
        Close();
        perfilController.Show();
    }
}
