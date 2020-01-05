using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksSceneController : MonoBehaviour
{
    [SerializeField]
    private GameDataStorage gameDataStorage;

    [SerializeField]
    private GameObject contentContainer;

    [SerializeField]
    private GameObject taskItemPrefab;

    private List<TaskItemController> tasksItems = new List<TaskItemController>();

    private List<GameDataTask> tasks = new List<GameDataTask>();

    private string levelId = AppProcessData.selectedLevel;

    // Start is called before the first frame update
    void Start()
    {
        for (int li = 0; li < gameDataStorage.Levels.Length;li++)
        {
            if (gameDataStorage.Levels[li].Id == levelId)
            {
                var taskIds = gameDataStorage.Levels[li].Tasks;
                for (int ti = 0; ti < gameDataStorage.Tasks.Length; ti++)
                {
                    if (Array.IndexOf(taskIds, gameDataStorage.Tasks[ti].Id)!=-1)
                    {
                        tasks.Add(gameDataStorage.Tasks[ti]);
                    }
                }
                break;
            }
        }

        for (int i = 0; i< tasks.Count; i++)
        {
            tasksItems.Add(Instantiate(taskItemPrefab, contentContainer.transform).GetComponent<TaskItemController>());
            tasksItems[i].SetQuestion(tasks[i].Question);
            tasksItems[i].gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
