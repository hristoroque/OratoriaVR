using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Controller : MonoBehaviour
{
    [SerializeField] protected GameObject ui;
    protected Animator animator;
    protected bool isOpen;
    // Start is called before the first frame update
    protected void Awake()
    {
        animator = ui.GetComponent<Animator>();
        Close();
    }

    public void Show()
    {
        isOpen = true;
        SetOpeness();
    }
    public void Close()
    {
        isOpen = false;
        SetOpeness();
    }
    private void SetOpeness()
    {
        animator.SetBool("isOpen", isOpen);
    }
}
