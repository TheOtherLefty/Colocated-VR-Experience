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
			this.transform.Translate (Vector3.forward);
		}

		void UnHighlight(){
			this.transform.Translate (Vector3.back);
		}

		void Clicked(){
			GM.CommSetting = this.CommSetting;
		}
	}
}