using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ThreadingSystem : MonoBehaviour
{
    public static ThreadingSystem Instance;

    int numberOfThreads;
    Queue<UnityAction> threadQueue = new Queue<UnityAction>();
    Queue<UnityAction> taskQueue = new Queue<UnityAction>();
    Thread[] threads;

    void Awake(){
        if(Instance == null){
            Instance = this;
        } else {
            Destroy(this);
        }

        threads = new Thread[numberOfThreads];
    }

    public void AddToThreadQueue(UnityAction action){
        threadQueue.Enqueue(action);
    }

    void AddToQueue(UnityAction action){
        taskQueue.Enqueue(action);
    }

    void Update(){
        DoTheradTasks();
        DoTasks();
    }

    void DoTheradTasks(){
        for (int i = 0; i < threadQueue.Count; i++)
        {
            Thread thread = GetFreeThread();

            if(thread != null){
                UnityAction action = threadQueue.Peek();
                threadQueue.Dequeue();

                thread = new Thread(action.Invoke);
            }
        }
    }

    void DoTasks() {
        for (int i = 0; i < taskQueue.Count; i++)
        {
            UnityAction action = taskQueue.Peek();
            taskQueue.Dequeue();
            
            action.Invoke();
        }
    }

    Thread GetFreeThread(){
        for (int i = 0; i < threads.Length; i++)
        {
            if(threads[i].IsAlive){
                return threads[i];
            }
        }

        return null;
    }
}
