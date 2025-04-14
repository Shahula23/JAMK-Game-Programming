using UnityEngine;

namespace AG2163
{
    public class RotateObject : MonoBehaviour
    {
        public float rotationSpeed = 45f;
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.M))
            {
                transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
            }
        }
    }
}