using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OwenandConnor
{
    public class FavThings : MonoBehaviour
    {
        private string[] favThingsArray = new string[4] { "games", "movies", "books", "food" };

        private List<string> favThingsList = new List<string>() { "games", "movies", "books", "food" };

        private void Start()
        {
            foreach (string favThing in favThingsArray)
            {
                Debug.Log("I Like " + favThing);
            }
        }
    }
    
}