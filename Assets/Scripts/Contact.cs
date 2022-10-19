using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace ConnorLuck
{ 
    public enum WorldLeader { Undefined, VPutin, DTrump, BObama }

    public class Contact : MonoBehaviour
    {
        [Header("Contact Details")]
        [SerializeField] private WorldLeader chosenWorldLeader = WorldLeader.Undefined;
        [SerializeField] private string fullName;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string streetAddress;
        [SerializeField] private string emailAddress;
        [SerializeField] private string prefName;

        public void Initialise()
        {
            
            if(chosenWorldLeader == WorldLeader.VPutin)
            Setup("Vladimir Putin", "+61469420619", "1 Mother Land Ln", "notevil@innocent.ru", "Big Bad Vlad");

            else if(chosenWorldLeader == WorldLeader.DTrump)
            Setup("Donald Trump", "555 360 420", "Trump Tower", "theystoletheelection@president.com", "Mr President");
            
            else if(chosenWorldLeader == WorldLeader.BObama)
            Setup("Barack Obama", "555 123 548", "The White House", "obamarules61@president.com", "President Obama");

            /*
            switch (chosenWorldLeader)
            {
                case WorldLeader.Undefined:
                    break;
                case WorldLeader.VPutin:
                    Setup("Vladimir Putin", "+61469420619", "1 Mother Land Ln", "notevil@innocent.ru", "Big Bad Vlad");
                    break;
                case WorldLeader.DTrump:
                    Setup("Donald Trump", "555 360 420", "Trump Tower", "theystoletheelection@president.com", "Mr President");
                    break;
                case WorldLeader.BObama:
                    Setup("Barack Obama", "555 123 548", "The White House", "obamarules61@president.com", "President Obama");
                    break;
                default:
                    break;
                    
            }
            */
        }
        private void Setup(string newFullName, 
                            string newPhoneNumber, 
                            string newStreetAddress, 
                            string newEmailAddress, 
                            string newPrefName)
        {
            fullName = newFullName;
            phoneNumber = newPhoneNumber;
            streetAddress = newStreetAddress;
            emailAddress = newEmailAddress;
            prefName = newPrefName;

        }
    }

}
