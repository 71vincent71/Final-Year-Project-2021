using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParkingSpot : MonoBehaviour
{
    //Whenever 2 collider's interact, in the case of our game when the truck reaches the parking spot.
    //We display a message in the console and reload our current scene which runs the game
    private void OnTriggerEnter(Collider other)
    {
            Debug.Log("Parking Completed! Resetting Game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
