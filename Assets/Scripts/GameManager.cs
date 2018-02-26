using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class GameManager : MonoBehaviour {
	public int CommSetting;
	public bool MenuShow;

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();

				Debug.Log ("\n\n\n ----- Game Manager Created --------- \n\n\n");

            }
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
		MenuShow = true;

    }

	void Update()
	{
		if (CommSetting != 0) {
			MenuShow = false;
		}
	}
}