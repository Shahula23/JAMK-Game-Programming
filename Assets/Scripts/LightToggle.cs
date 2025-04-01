using UnityEngine;

namespace AG2163
{
    public class LightToggle : MonoBehaviour
    {
        public Light pointLight;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                pointLight.enabled = !pointLight.enabled;
            }
        }
    }
}