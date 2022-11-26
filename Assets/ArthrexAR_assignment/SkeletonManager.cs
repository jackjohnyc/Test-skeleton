using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonManager : MonoBehaviour
{
    
    public GameObject mainSkeleton; // Get reference to the main skeleton object

    public SkinnedMeshRenderer skeletonMeshRenderer; // Get Reference to the skinned mesh renderer

    public Material skeletonSolid;  // Normal material
    public Material skeletonHolo;  // Holographic material
  
    private bool autoRotate;
    private bool matToggle;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<UIManager>().TrackerFound();  // Call tracker found function to disable find tracker message and enable buttons
    }

    // Update is called once per frame
    void Update()
    {
        if (autoRotate)
        {
            mainSkeleton.transform.Rotate(0, 0, Time.deltaTime * 50); // Rotate the 3d model on z axis 
        }
    }

    public void ToggleMaterial() // Change material to holographic and vice versa
    {
        if (!matToggle)
        {
           
            skeletonMeshRenderer.material = skeletonHolo;
            matToggle = true;
        }
        else
        {
    
            skeletonMeshRenderer.material = skeletonSolid;
            matToggle = false;
        }
    }

    public void ToggleAutoRotate() // Toggle rotation of the 3D Model
    {
        if (!autoRotate)
        {
            autoRotate = true;
        }
        else
        {
            autoRotate = false;

        }
    }
}
