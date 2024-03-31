using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TaskOne : MonoBehaviour
{
    private Queue<string> playerQueue = new Queue<string>();
    private int playerCount = 26;
    public void AddPlayers()
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
    }

    void Start()
    {
        AddPlayers();

        string login = playerQueue.Dequeue();

        Debug.Log("Initial login queue created. There are " + playerCount + " players in the queue.");
        Debug.Log(login);

    }

    
    void Update()
    {
        
    }
}
