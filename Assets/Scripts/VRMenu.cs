using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMenu : MonoBehaviour {
    private bool menuState = false;
    // Update is called once per frame
    void Update () {
        if (menuState != GameManager.Instance.MenuShow)
        {
            Renderer menurenderer = GetComponent<Renderer>();
            menurenderer.enabled = GameManager.Instance.MenuShow;
            menuState = GameManager.Instance.MenuShow;
            Debug.Log("menurenderer = " + menurenderer.enabled);
        }
	}
}
