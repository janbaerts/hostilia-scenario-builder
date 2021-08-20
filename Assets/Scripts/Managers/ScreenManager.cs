using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;

	private GameObject[] allScreens;

	private void Awake()
	{
        Assert.IsNotNull(mainMenu);

		allScreens = new GameObject[]
		{
			mainMenu
		};
	}

	// Start is called before the first frame update
	void Start()
    {
        ShowScreen(mainMenu);
    }

	
	// Update is called once per frame
	void Update()
    {
        
    }

	private void ShowScreen(GameObject screen)
	{
		ClearAllScreens();
		screen.SetActive(true);
	}

	private void ClearAllScreens()
	{
		foreach (GameObject go in allScreens)
			go.SetActive(false);
	}
}
