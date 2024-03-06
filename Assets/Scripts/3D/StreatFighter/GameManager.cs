using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public LevelDataBase levelDataBase;
    public CharacterDataBase characterDataBase;
    public int currentLevelId = 0;
    public List<int> currentCharacterId = new List<int>(); //liste d'id de persos. Ici, le 0 est l'id de personnage pour le joueur 1. currentCharacterId[0] est donc �gale � l'id de personnage choisi par le joueur 1

    private void Awake()
    {
        GameManager[] objs = FindObjectsOfType<GameManager>();

        if (objs.Length > 1) // si on trouve plusieurs game manager, on d�truit celui-ci
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject); // si on trouve pas d'autre game manager, alors on garde celui-l�
    }

    public void OnSelectLevel(int newLevel) //simple, on choisit un stage et l'id actuel le garde en m�moire
    {
        currentLevelId = newLevel;
    }

    public void OnSelectCharacter() //Ici on s�lectionne le joueur. Il faut pouvoir prendre en compte le fait que c'est en multijoueur, et savoir � qui associer le personnage
    {

    }

    //public LevelData GetCurrentLevel() //pour acc�der au niveau actuel, on a qu'� appeler gameManager.GetCurrentLevel()
    //{
    //    return levelDataBase.levels[currentLevelId];
    //}
    public CharacterData GetCurrentCharacter(int playerId) //Pareil pour les personnages, mais � appliquer en fonction des joueurs
    {
        return characterDataBase.characters[currentCharacterId[playerId]]; //on retourne le personnage choisit par le joueur � l'id = playerId
    }
}
