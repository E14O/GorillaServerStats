using BepInEx;
using GorillaServerStats.Behaviours;
using GorillaServerStats.Tools;
using UnityEngine;

namespace GorillaServerStats
{
    [BepInPlugin(Constants.GUID, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start() => new GameObject("GSS", typeof(Data), typeof(TextFinder), typeof(Main));
    }
}
