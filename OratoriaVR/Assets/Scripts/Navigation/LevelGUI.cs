using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class LevelGUI : MonoBehaviour
{
    public Image levelImage;
    private Color onHoverColor = new Color(0.1f, 0.4f, 0.3f);
    private Color onClickColor = new Color(0.1f, 0.5f, 0.3f);
    private LevelsController levelsController;
   
    private Color normalColor;

    private void Start()
    {
        Debug.Log("Inicializando el elemento");
        levelImage = GetComponent<Image>();
        normalColor = levelImage.color;
        levelsController = GameObject.FindGameObjectWithTag("Controllers").GetComponent<LevelsController>();
    }
    public void OnHover()
    {
        Debug.Log("Hovering the element");
        levelImage.color = onHoverColor;
    }
    public void OnPointerExit()
    {
        Debug.Log("Exing off the level");
        levelImage.color = normalColor;
    }
    public void OnClickDown()
    {
        levelsController.GoToLevel(null);
    }
    public void OnClickUp()
    {
        Debug.Log("Going to the new event");
        levelImage.color = onHoverColor;
    }
}
