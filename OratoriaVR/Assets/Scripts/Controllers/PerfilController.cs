using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State{
    open,
    close,
    animating
}

public class PerfilController: Controller
{
    private LevelsController levelController;
    private ReporteControlles reporteController;

    private void Awake()
    {
        base.Awake();
        levelController = GetComponent<LevelsController>();
        reporteController = GetComponent<ReporteControlles>();
    }

    public void GoToLevelSelection()
    {
        Close();
        levelController.Show();
    }

    public void GoToReportes()
    {
        Close();
        reporteController.Show();
    }
}
