using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weekone : MonoBehaviour
{
    List<string> Songname = new List<string>() { "Weather Report", "Heavy Weather", "White Snake", "C-Moon", "Made in Heaven" };
    public List<Text> SongList = new List<Text>();

    public InputField input_Field;
    public GameObject Answer;

    void Start()
    {
        input_Field.onEndEdit.AddListener(FindSongName);

        for (int i = 0; i <= Songname.Count - 1; i++)
        {
            SongList[i].text = Songname[i].ToString();
        }
    }

    public void FindSongName(string SongList)
    {
        if (Songname.Contains(input_Field.text))
        {
            Answer.GetComponent<Text>().text = "[ " + SongList + "]" + " is found.";
        }
        else
        {
            Answer.GetComponent<Text>().text = "[ " + SongList  +"] " + " is not found. ";
        }
    }
}