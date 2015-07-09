using UnityEngine;
using System;
using System.Collections;

//Script used to show feedback to player
public class ControlCharacters : MonoBehaviour
{
    public GameObject Character1;
    public CharacterDetails Character1Details;
 
    public GameObject Character2;
    public CharacterDetails Character2Details;

    // Use this for initialization
    void Start()
    {
        BreakButton.OnBreak += OnBreak;
    }

    void OnBreak()
    {
        StartCoroutine("UpdateCharacters");
    }

    IEnumerator UpdateCharacters()
    {
        //wait for sometime to allow updating of the variables to be finished.
        yield return new WaitForSeconds(.1f);

        //change sprites according to result.
        if (GameData.NumberofPiecesforCharacter1 > GameData.NumberofPiecesforCharacter2)                //char2 has less.
        {
            Character1.GetComponent<SpriteRenderer>().sprite = Character1Details.HappySprite;
            Character2.GetComponent<SpriteRenderer>().sprite = Character2Details.SadSprite;
        }
        else if (GameData.NumberofPiecesforCharacter1 < GameData.NumberofPiecesforCharacter2)           //char1 has less
        {
            Character1.GetComponent<SpriteRenderer>().sprite = Character1Details.SadSprite;
            Character2.GetComponent<SpriteRenderer>().sprite = Character2Details.HappySprite;
        }
        else                                                                                            //both have equal
        {
            Character1.GetComponent<SpriteRenderer>().sprite = Character1Details.HappySprite;
            Character2.GetComponent<SpriteRenderer>().sprite = Character2Details.HappySprite;
        }
    }

    [Serializable]
    public class CharacterDetails
    {
        public Sprite NormalSprite;
        public Sprite HappySprite; 
        public Sprite SadSprite;
    }
}
