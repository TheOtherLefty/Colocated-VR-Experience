using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

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

            }
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
		MenuShow = true;

		NetworkManager myNetworkManager = this.GetComponent (typeof(NetworkManager)) as NetworkManager;

		NetworkClient host = myNetworkManager.StartHost();
    }

	void Update(){
		if (CommSetting != 0) {
			MenuShow = false;
		}
	}

}
