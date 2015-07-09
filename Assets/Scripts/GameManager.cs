using UnityEngine;
using System.Collections;
using BreakChocolate;

public class GameManager : MonoBehaviour
{
    //various prefabs used to instantiate.
    public GameObject piecePrefab;
    public GameObject barPrefab;

    //the chocolate bar object.
    private ChocolateBar _bar;

    // Use this for initialization
    void Start()
    {
        //instantiate chocolatebar and initialize its control class.
        GameObject hooksGO = GameObject.Instantiate(barPrefab, Vector3.zero, Quaternion.identity) as GameObject;
        ChocolateBarHooks hooks = hooksGO.GetComponent<ChocolateBarHooks>();
        _bar = new ChocolateBar(hooks);

        //use generator factory to create a random bar.
        ChocolateBarGeneratorFactory factory = new ChocolateBarGeneratorFactory();
        int noOfPieces = factory.NumberofPiecesRange[Random.Range(0, factory.NumberofPiecesRange.Length)];
        Debug.Log("[ChocoPieceTest:Start]:{noOfPieces:" + noOfPieces.ToString() + "}");
        ChocolateBarGenerator generator = factory.Create(_bar, noOfPieces);
        _bar.PieceList = generator.CreateBar(_bar, piecePrefab);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

