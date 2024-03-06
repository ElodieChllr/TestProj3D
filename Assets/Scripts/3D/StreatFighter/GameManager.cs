using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public LevelDataBase levelDataBase;
    public CharacterDataBase characterDataBase;
    public int currentLevelId = 0;
    public List<int> currentCharacterId = new List<int>(); //liste d'id de persos. Ici, le 0 est l'id de personnage pour le joueur 1. currentCharacterId[0] est donc égale à l'id de personnage choisi par le joueur 1

    private void Awake()
    {
        GameManager[] objs = FindObjectsOfType<GameManager>();

        if (objs.Length > 1) // si on trouve plusieurs game manager, on détruit celui-ci
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject); // si on trouve pas d'autre game manager, alors on garde celui-là
    }

    public void OnSelectLevel(int newLevel) //simple, on choisit un stage et l'id actuel le garde en mémoire
    {
        currentLevelId = newLevel;
    }

    public void OnSelectCharacter() //Ici on sélectionne le joueur. Il faut pouvoir prendre en compte le fait que c'est en multijoueur, et savoir à qui associer le personnage
    {

    }

    //public LevelData GetCurrentLevel() //pour accéder au niveau actuel, on a qu'à appeler gameManager.GetCurrentLevel()
    //{
    //    return levelDataBase.levels[currentLevelId];
    //}
    public CharacterData GetCurrentCharacter(int playerId) //Pareil pour les personnages, mais à appliquer en fonction des joueurs
    {
        return characterDataBase.characters[currentCharacterId[playerId]]; //on retourne le personnage choisit par le joueur à l'id = playerId
    }
}
