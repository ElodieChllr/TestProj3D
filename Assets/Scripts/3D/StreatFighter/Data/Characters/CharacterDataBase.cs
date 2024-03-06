using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DataBase/Characters", fileName = "characterDataBase")]
public class CharacterDataBase : ScriptableObject
{
    public List<CharacterData> characters;
}

