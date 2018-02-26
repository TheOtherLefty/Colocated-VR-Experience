using System;
using UnityEngine;

namespace VRStandardAssets.Utils
{
    // This class should be added to any gameobject in the scene
    // that should react to input based on the user's gaze.
    // It contains events that can be subscribed to by classes that
    // need to know about input specifics to this gameobject.
    public class sphere : MonoBehaviour
    {
        public int CommSetting;
		public VRInteractiveItem ball;
		public Renderer circlething;
        public GameManager GM;


        void Awake()
        {
			ball = this.GetComponent<VRInteractiveItem>();
			circlething = GetComponent<Renderer> ();
        }

        void OnEnable()
        {
            ball.OnOver += Highlight;
            ball.OnOut += UnHighlight;
            ball.OnClick += Clicked;
        }

        void OnDisable()
        {
            ball.OnOver -= Highlight;
            ball.OnOut -= UnHighlight;
            ball.OnClick -= Clicked;
        }

        void Highlight()
        {
			circlething.material.color = Color.white;
        }

        void UnHighlight()
        {
			circlething.material.color = Color.red;
        }

        void Clicked()
        {
            GM.CommSetting = this.CommSetting;
        }
    }
}