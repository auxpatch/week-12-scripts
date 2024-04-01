using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class TaskTwo : MonoBehaviour
{
    public string[] smallernames = new string[#ofRandomNamesYouWant];

    Random Random = new Random();
    private HashSet<string> names = new HashSet<string>
    {NAMES HERE};


    Random random = new Random(); //Random Gen

    void Start()
    {

        int nameCount = 0; //create a new list from the hashset with the random going
        List<String> namesList = new List<string>(names);
        while (nameCount < smallernames.Length && namesList.Count > 0)
        {
            int randomCount = random.Next(namesList.Count);  //goes until it meets the amount in the array
            string randomName = namesList[randomCount];
            smallernames[nameCount++] = randomName; //ads all the names to the array and compares the array and the hashset
            namesList.Remove(randomName);
        }
        Debug.Log("Created the name array:" + string.Join(", ", smallernames));

        names.IntersectWith(smallernames);
        Debug.Log("The array has duplicate names: " + string.Join(", ", names));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
