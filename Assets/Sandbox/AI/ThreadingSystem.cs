using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ThreadingSystem : MonoBehaviour
{
    public static ThreadingSystem Instance;

    public const int numberOfThreads = 3;
    Queue<UnityAction>[] threadQueues;
    
    Queue<UnityAction> taskQueue = new Queue<UnityAction>();

    Thread[] threads;


    void Awake(){
        if(Instance == null){
            Instance = this;
        } else {
            Destroy(this);
        }

        threadQueues = new Queue<UnityAction>[numberOfThreads];

        for (int i = 0; i < numberOfThreads; i++)
        {
            threadQueues[i] = new Queue<UnityAction>();
        }

        InitializeThreads();
    }

    public void AddToThreadQueue(int thread, UnityAction action){
        threadQueues[thread].Enqueue(action);
    }

    public void Schedule(UnityAction action){
        taskQueue.Enqueue(action);
    }

    void Update(){
        DoTheradTasks();
        DoTasks();
    }

    void InitializeThreads(){
        threads = new Thread[numberOfThreads];

        // Create therads to be able to check if the threads are alive        
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread( () => { return; } );
        }
    }

    void DoTheradTasks(){
        for (int i = 0; i < threadQueues.Length; i++)
        {
            if(!threads[i].IsAlive && threadQueues[i].Count > 0) {
                UnityAction action = threadQueues[i].Peek();
                threadQueues[i].Dequeue();

                threads[i] = new Thread(action.Invoke);
                threads[i].Start();
            }
        }
    }

    void DoTasks() {
        for (int i = 0; i < taskQueue.Count; i++)
        {
            UnityAction action = taskQueue.Peek();
            taskQueue.Dequeue();
            
            if(action != null){
                action.Invoke();
            }
        }
    }
}
