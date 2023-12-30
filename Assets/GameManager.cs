using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private UIManager manager;
    public UIManager uiManager
    {
        get
        {
            if (manager == null)
            {

                manager = FindObjectOfType<UIManager>();
            }
            return manager;
        }
    }

    private BodyCustomizeController controller;
    public BodyCustomizeController CharacterController
    {
        get
        {
            if (controller == null)
            {
                controller = FindObjectOfType<BodyCustomizeController>();
            }
            return controller;
        }
    }

}



    
