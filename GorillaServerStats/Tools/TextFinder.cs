using TMPro;
using UnityEngine;

namespace GorillaServerStats.Tools
{
    public class TextFinder : MonoBehaviour
    {
        public static TextFinder Instance;

        public TextMeshPro _HeaderText, _BodyText;

        void Awake() => Instance = this;

        void Start()
        {
            string _main = "Environment Objects/LocalObjects_Prefab/TreeRoom";

            _BodyText = GameObject.Find($"{_main}/motdBodyText").GetComponent<TextMeshPro>();
            _HeaderText = GameObject.Find($"{_main}/motdHeadingText").GetComponent<TextMeshPro>();
        }
    }
}
