using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button newScenarioButton;
    [SerializeField] private Button editScenarioButton;
    [SerializeField] private Button exportScenarioButton;

	private void Awake()
	{
        Assert.IsNotNull(newScenarioButton);
        Assert.IsNotNull(editScenarioButton);
        Assert.IsNotNull(exportScenarioButton);
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
