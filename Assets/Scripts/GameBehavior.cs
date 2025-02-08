using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//public class GameBehavior : MonoBehaviour
//{
//    public int MaxItems = 4;

//    public TMP_Text HealthText;
//    public TMP_Text ItemText;
//    public TMP_Text ProgressText;

//    public Button WinButton;
//    public Button LossButton;

//    [SerializeField] private int _playerHP = 10;


//    void Start()
//    {
//        ItemText.text += _itemsCollected;
//        HealthText.text += _playerHP;
//    }

//    private int _itemsCollected = 0;
//    public int Items
//    {
//        get { return _itemsCollected; }
//        set
//        {
//            _itemsCollected = value;
//            ItemText.text = "Items: " + Items;

//            if (_itemsCollected >= MaxItems)
//            {
//                ProgressText.text = "You've found all the items!";
//                WinButton.gameObject.SetActive(true);
//                Time.timeScale = 0f;
//            }
//            else
//            {
//                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) + " more!";
//            }
//        }
//    }

//    public int HP
//    {

//        get { return _playerHP; }
//        set
//        {
//            _playerHP = value;
//            HealthText.text = "Health: " + HP;
//            if (_playerHP <= 0)
//            {
//                ProgressText.text = "You want another life with that?";
//                LossButton.gameObject.SetActive(true);
//                Time.timeScale = 0;
//            }
//            else
//            {
//                ProgressText.text = "Ouch... that's got hurt.";
//            }

//        }

//    }

//    public void RestartScene()
//    {
//        SceneManager.LoadScene(0);
//        Time.timeScale = 1f;
//    }
//}

public class GameBehavior : MonoBehaviour
{
    public int MaxItems = 4;

    public TMP_Text HealthText;
    public TMP_Text ItemText;
    public TMP_Text ProgressText;

    public Button WinButton;
    public Button LossButton;

    private int _playerHP = 10;

    public void UpdateScene(string updatedText)
    {
        ProgressText.text = updatedText;
        Time.timeScale = 0f;
    }

    private int _itemsCollected = 0;
    public int Items
    {
        get { return _itemsCollected; }

        set
        {
            _itemsCollected = value;
            ItemText.text = "Items Collected: " + Items;
            if (_itemsCollected >= MaxItems)
            {
                WinButton.gameObject.SetActive(true);
                UpdateScene("You've found all the items!");
            }
            else
            {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) +
                " more to go!";
            }
        }
    }

    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            HealthText.text = "Player Health: " + HP;
            if (_playerHP <= 0)
            {
                LossButton.gameObject.SetActive(true);
                UpdateScene("You want another life with that?");
            }
            else
            {
                ProgressText.text = "Ouch... that's got hurt.";
            }
            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    }
}