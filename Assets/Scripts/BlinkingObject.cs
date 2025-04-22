using UnityEngine;

namespace AG2163
{
    public class BlinkingObject : MonoBehaviour
    {
        public float blinkSpeed = 1f;
        private Renderer objRenderer;

        void Start()
        {
            objRenderer = GetComponent<Renderer>();
        }

        void Update()
        {
            float wave = Mathf.Sin(Time.time * blinkSpeed);
            objRenderer.enabled = wave > 0;
        }
    }
}