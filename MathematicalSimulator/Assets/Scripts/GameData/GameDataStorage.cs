using UnityEngine;

[CreateAssetMenu(fileName = "GameDataStorage", menuName = "ScriptableObjects/GameDataStorage", order = 1)]
public class GameDataStorage : ScriptableObject
{
    public GameDataLevel[] Levels;

    public GameDataTask[] Tasks;

}
