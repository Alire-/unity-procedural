using UnityEngine;
using System.Collections;


public class TileSnake : MonoBehaviour {
//public vars to expose in unity
public GameObject tileTexture;
public GameObject bushTexture;
public GameObject playerCharacter;
public int tileNumber = 400;
public int bushChance;
public int roomChance;



void Start () {
    //top
    //need this to instantiate
    GameObject tileInstance;
    

    //setting variables to try and control
    //the x and y values tiles are set at
    //hoping this is where the last approach failed
    int x = 0;
    int y = 0;

    //variable that stores position of instantiation
    Vector3 tilePositon = new Vector3(x , y, 0);

    //actually instantiate the tile
    //tileInstance = Instantiate(tileTexture, tilePositon, transform.rotation) as GameObject;
    //generate random number and use that to determine placement of next tile in any direction
    //tileNumber is how many tiles
    bool isPlayer;
    isPlayer = false;
    for (int i = 0; i < tileNumber; i++)
        {
        int rotateZ;
        rotateZ = Random.Range(0, 361);
        int randyGen;
        int randyTwo;
        int randyBush;
        double playerHeight = 2;
        double treeHeight = 1.5;
        Quaternion treeRotation = Quaternion.Euler(0, rotateZ, 0);
  
        randyTwo = Random.Range(0, roomChance);
        randyGen = Random.Range(0, 42);
        randyBush = Random.Range(0, bushChance);
        
        

        if ((randyGen > 0) && (randyGen < 11))
        {
            if (randyBush == 5)
            {
                tileInstance = tileInstance = Instantiate(bushTexture, new Vector3(x, (float)treeHeight, y), treeRotation) as GameObject;
            }
             y++;
            tilePositon = new Vector3(x, 0, y);
            if (isPlayer == false){
            playerCharacter = Instantiate(playerCharacter, new Vector3(x, (float)playerHeight, y), transform.rotation) as GameObject;
            isPlayer = true;
            }
                tileInstance = Instantiate(tileTexture, tilePositon, transform.rotation) as GameObject;

            if (randyTwo == 5)
            {
                tileInstance = Instantiate(tileTexture, new Vector3(x, 0, y + 1), transform.rotation) as GameObject;

            }
        }   

       
    else if ((randyGen > 10) && (randyGen < 21))
        {
            if (randyBush == 5)
            {
                tileInstance = Instantiate(bushTexture, new Vector3(x, (float)treeHeight, y), treeRotation) as GameObject;
            }
        y--;
        tilePositon = new Vector3(x, 0, y);
        tileInstance = Instantiate(tileTexture, tilePositon, transform.rotation) as GameObject;
        if (randyTwo == 5)
        {
            tileInstance = Instantiate(tileTexture, new Vector3(x, 0, y - 1), transform.rotation) as GameObject;
        }
    }

    

    else if ((randyGen > 20) && (randyGen < 31))
        {
            if (randyBush == 5)
            {
                tileInstance = Instantiate(bushTexture, new Vector3(x, (float)treeHeight, y), treeRotation) as GameObject;
            }
        x++;
        tilePositon = new Vector3(x, 0, y);
        tileInstance = Instantiate(tileTexture, tilePositon, transform.rotation) as GameObject;
        if (randyTwo == 5)
        {
            tileInstance = Instantiate(tileTexture, new Vector3(x + 1, 0, y), transform.rotation) as GameObject;
        }

    }

    else if ((randyGen > 30) && (randyGen < 41))
        {
            if (randyBush == 5)
            {
                tileInstance = Instantiate(bushTexture, new Vector3(x, (float)treeHeight, y), treeRotation) as GameObject;
            }
        x--;
        tilePositon = new Vector3(x, 0, y);
        tileInstance = Instantiate(tileTexture, tilePositon, transform.rotation) as GameObject;
        if (randyTwo == 5)
        {
            tileInstance = Instantiate(tileTexture, new Vector3(x - 1, 0, y), transform.rotation) as GameObject;
        }

        }
     }
}

void Update () {
//update starts here
}
}