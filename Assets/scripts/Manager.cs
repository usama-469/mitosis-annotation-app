using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Firebase.Database;

public class Manager : MonoBehaviour
{
   // public string folderPath = "Assets/Testing Images"; // Change this to your image folder path
    public GameObject imagePrefab; // Prefab to use for each image
    private string answer = "";
    public int i = 0;

    public InputField Name;
    private string nameuser;
    [SerializeField] GameObject[] imageArray = new GameObject[57];



    private string userID, deviceID;

    private DatabaseReference dbReference;

    public GameObject thankYou, gamePanel, introPanel;
    void Start()
    {
        
        dbReference = FirebaseDatabase.DefaultInstance.RootReference; 

        answer = "";
        Debug.Log("start run");
        // LoadImages();
        introPanel.SetActive(true);
        gamePanel.SetActive(false);
        thankYou.SetActive(false);

       // refresh(); 
        imageArray[0].SetActive(true);


    }

    public void CreateUser()
    {
        nameuser = Name.text;
        User newUser = new User(nameuser, answer);
        //userID = nameuser;
        deviceID = SystemInfo.deviceUniqueIdentifier;       //to differentiate between users of same name

        userID = nameuser + "   " + deviceID;
        string json = JsonUtility.ToJson(newUser);

        dbReference.Child("users").Child(userID).SetRawJsonValueAsync(json);

        //FirebaseDatabase.DefaultInstance.RootReference.Child("users").Child(userID).SetRawJsonValueAsync(json);


    }


    void refresh()
    {
        for (i = 0; i < imageArray.Length; i++)

        {
            imageArray[i].SetActive(false);


        }


    }

    public void yesButton()
    {
        answer = answer + "1\n";
        imageArray[i].SetActive(false);
        i +=1;
        imageArray[i].SetActive(true);

        if (i == 98) { gamePanel.SetActive(false); thankYou.SetActive(true); }

    }

    public void noButton()
    {
        answer = answer + "0\n";
        imageArray[i].SetActive(false);
        i += 1;
        imageArray[i].SetActive(true);

        if (i == 98) { gamePanel.SetActive(false); thankYou.SetActive(true); }
    }


    public void introButto()

    {
        //if name not empty
    
            introPanel.SetActive(false);
            gamePanel.SetActive(true);
            imageArray[i].SetActive(true);
       

    }

    public void welcomeButt()
    {
        i = 0;
        refresh();

        i = 0;
        thankYou.SetActive(false);
        gamePanel.SetActive(false);
        introPanel.SetActive(true);
        //Name = null;
        
     
    }


    //public void LoadImages()
    //{
    //    Debug.Log("load images run");
    //    string[] imagePaths = Directory.GetFiles(folderPath, "*.jpg"); // You can change the file extension based on your image format

    //    imageArray = new GameObject[imagePaths.Length];

    //    for (int i = 0; i < imagePaths.Length; i++)
    //    {
    //        Texture2D texture = LoadTexture(imagePaths[i]);

    //        if (texture != null)
    //        {
    //            Debug.Log("if run");
    //            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one * 0.5f);
    //            GameObject imageObject = Instantiate(imagePrefab, Vector3.zero, Quaternion.identity);
    //            imageObject.GetComponent<SpriteRenderer>().sprite = sprite;
    //            imageArray[i] = imageObject;
    //            Debug.Log(imagePaths[i] + "is LOADED-----------------------------");
    //        }
    //        else { Debug.Log("Assets null---------could not find any image");  }
    //    }


    //}

    //Texture2D LoadTexture(string path)
    //{
    //    byte[] fileData = File.ReadAllBytes(path);
    //    Texture2D texture = new Texture2D(2, 2);
    //    texture.LoadImage(fileData); // This function reads the image file data
    //    Debug.Log("textures run");
    //    return texture;
    //}
}
