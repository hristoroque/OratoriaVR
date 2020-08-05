using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<Level> levels;
    public GameObject levelGUIContainer;
    public GameObject levelGUIItem;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Level level in levels){
            Instantiate(levelGUIItem,levelGUIContainer.transform);
        }
    }
}
