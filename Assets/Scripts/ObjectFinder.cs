using UnityEngine;

namespace AG2163
{
    public class SimpleFinder : MonoBehaviour
    {
        public GameObject[] dragAndDropObjects; // Option 1: Assign cubes in Inspector

        void Start()
        {
            ////Method 1: Using Drag and Drop(Inspector assignment)
            //foreach (GameObject cube in dragAndDropObjects)
            //{
            //    Renderer rend = cube.GetComponent<Renderer>();
            //    if (rend != null)
            //    {
            //        rend.material.color = Color.green; // Change the color of the cube
            //    }
            //}

            //Method 2: Using Tag(Find cubes by their tag)
            GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube"); // Find all cubes by their tag
            foreach (GameObject cube in cubes)
            {
                Renderer rend = cube.GetComponent<Renderer>();
                if (rend != null)
                {
                    rend.material.color = Color.green; // Change color to green
                }
            }
        }
    }
}