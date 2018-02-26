using System;
using UnityEngine;

namespace VRStandardAssets.Utils
{
    // This class should be added to any gameobject in the scene
    // that should react to input based on the user's gaze.
    // It contains events that can be subscribed to by classes that
    // need to know about input specifics to this gameobject.
    public class VRMenuItem : MonoBehaviour
    {
		public int CommSetting;
		public VRInteractiveItem MenuPanel;
		public GameManager GM;

		void Awake(){
			MenuPanel = this.GetComponent<VRInteractiveItem>();
			GM =  GetComponent<GameManager>();
		}

		void OnEnable(){
			MenuPanel.OnOver += Highlight;
			MenuPanel.OnOut += UnHighlight;
			MenuPanel.OnClick += Clicked;
		}

		void OnDisable(){
			MenuPanel.OnOver -= Highlight;
			MenuPanel.OnOut -= UnHighlight;
			MenuPanel.OnClick -= Clicked;
		}

		void Highlight(){
			this.transform.Translate (Vector3.forward *3);
			Debug.Log ("\n\n\n Oh wow, you've looked at a menu item <3<3<3 \n\n\n");
		}

		void UnHighlight(){
			this.transform.Translate (Vector3.back *3);
			Debug.Log ("\n\n\n Oh, I guess you had something else to be doing now. Have fun not looking at menus xx \n\n\n");
		}

		void Clicked(){
			GM.CommSetting = this.CommSetting;
		}
	}
}