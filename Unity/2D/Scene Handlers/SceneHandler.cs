// AUTHOR: Tal Zichlinsky
//
// This code executes on collision between the game object
// the code is attached to and a game object with the corresponding tag.
// On execution, this code will load the scene with the corresponding name.
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelOnCollision : MonoBehaviour
{
    [SerializeField] private string triggeringTag;
    [Tooltip("Next scene name")]
    [SerializeField] private string nextScene;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == triggeringTag)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
