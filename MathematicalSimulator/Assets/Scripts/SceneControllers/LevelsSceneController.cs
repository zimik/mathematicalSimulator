using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEngine.SceneManagement;

public class LevelsSceneController : MonoBehaviour
{
    [SerializeField]
    private GameDataStorage dataStorage;

    [SerializeField]
    private GameObject listContent;

    [SerializeField]
    private GameObject listItemPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //        Observable.Create<GameDataLevel[]>(dataStorage.Levels);
        //        Observable<[GameDataLevel]>

        for (int i=0; i<dataStorage.Levels.Length; i++)
        {
            var obj  = Instantiate(listItemPrefab, listContent.transform);
            string levelId = dataStorage.Levels[i].Id;
            obj.AddComponent<ObservablePointerClickTrigger>().OnPointerClickAsObservable().Subscribe((x) => 
            {
                Debug.Log(levelId);
                AppProcessData.selectedLevel = levelId;
                SceneManager.LoadScene("TasksScene");
            });
            obj.SetActive(true);
            obj.GetComponent<LevelItemController>().setLevel(dataStorage.Levels[i].Level);
//            ObservablePointerClickTrigger.(obj.PointerClickTrigger
//            obj.GetComponent<LevelItemController>();
                //UpdateAsObservable().Where(_ => Input.GetMouseButtonUp(0)).Subscribe((x) => Debug.Log(i));
            //var clickFlow = obj.GetComponent<LevelItemController>().UpdateAsObservable().Where(_ => Input.GetMouseButtonUp(0)).Subscribe((x) => Debug.Log(i));
            //            clickFlow.Subscribe();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
