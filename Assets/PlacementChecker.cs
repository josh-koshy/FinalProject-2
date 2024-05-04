using UnityEngine;

public class PlacementChecker : MonoBehaviour
{
    public GameObject winScreen; // Assign the win screen UI element
    private int cubeCount = 0; // To count cubes within the area

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            cubeCount++; // Increment count when a cube enters
            CheckCompletion();
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            cubeCount--; // Decrement count when a cube exits
        }
    }

    void CheckCompletion()
    {
        // Check if all required cubes are within the target area
        if (cubeCount == GameObject.FindGameObjectsWithTag("Cube").Length)
        {
            winScreen.SetActive(true); // All cubes are inside the area
        }
    }
}