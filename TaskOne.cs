using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TaskOne : MonoBehaviour
{
    private Queue<string> playerQueue = new Queue<string>();
    public int playerCount;

    void Start()
    {
        playerQueue.Enqueue("Son Goku");
        playerQueue.Enqueue("Celyca");
        playerQueue.Enqueue("Dani");
        playerQueue.Enqueue("Cherry");
        playerQueue.Enqueue("Brennan");
        playerQueue.Enqueue("Roberto");
        playerQueue.Enqueue("Kari");
        playerQueue.Enqueue("Richard");
        playerQueue.Enqueue("Gina");
        playerQueue.Enqueue("Jakob");
        playerQueue.Enqueue("Francis");
        playerQueue.Enqueue("Garry");
        playerQueue.Enqueue("Cecilia");
        playerQueue.Enqueue("Gordon");
        playerQueue.Enqueue("Mina");
        playerQueue.Enqueue("Sol");
        playerQueue.Enqueue("Son");
        playerQueue.Enqueue("Ken");
        playerQueue.Enqueue("Ryu");
        playerQueue.Enqueue("Terry");
        playerQueue.Enqueue("Jean-Pierre");
        playerQueue.Enqueue("Jotaro");
        playerQueue.Enqueue("Anya");
        playerQueue.Enqueue("Gwyneth");
        playerQueue.Enqueue("Anji");
        playerQueue.Enqueue("A.B.A.");

        Debug.Log("Initial login queue created. There are " + playerCount + " players in the queue.");

        if (playerCount == 0)
        {
            Debug.Log("There is no one in queue!");
        }
        else if(playerCount > 26)
        {
            Debug.Log("There's too many login attempts currently. Please try again later.");
        }
        else
        {
            for (int i = 0; i < playerCount; i++)
            {
                Debug.Log(playerQueue.Dequeue() + " is now inside the game.");
                Debug.Log(playerQueue.Peek() + " is trying to login and is added to the login queue.");
            }
        }


    }

    
    void Update()
    {
        
    }
}
