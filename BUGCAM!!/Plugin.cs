using BepInEx;
using System;
using UnityEngine;
using Utilla;

namespace BUGCAM__
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool bugcam;
        GameObject cAM;
        GameObject Bug;
        void Start()
        {
            cAM = GameObject.Find("Shoulder Camera");
            Bug = GameObject.Find("Floating Bug Holdable");
        }
        void OnGUI()
        {
            bugcam = GUI.Toggle(new Rect(0, 120, 100, 100), bugcam, "BUGCAM!");
        }
        void Update()
        {
            if (Bug == null) Start();
            if (bugcam)
            {
                cAM.transform.GetChild(0).gameObject.SetActive(false);
                cAM.transform.position = Bug.transform.position;
                cAM.transform.rotation = Bug.transform.rotation;
            }
            else 
            {
                cAM.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}
