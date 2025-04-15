using UnityEngine;

namespace AG2163
{
    public class PulseObject : MonoBehaviour
    {
        void Update()
        {
            float scale = 1 + Mathf.Sin(Time.time) * 0.5f;
            transform.localScale = Vector3.one * scale;
        }
    }
}