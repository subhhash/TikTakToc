using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class tictacScript : MonoBehaviour
{
    TMP_Text[,] arr = new TMP_Text[3,3];
    public List<Button> Btns;
    public List<TMP_Text> TicTacBtns;
    public TMP_Text playerX, PlayerO;
    int PlayerCountX=0, PlayerCountO=0;

    private bool BtnO = true;
    private bool BtnX = false;

    public AudioSource clickSound;

    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                arr[i, j] = TicTacBtns[count];
                count++;
            }
        }


        ////log
        //for(int i=0;i<arr.GetLength(0);i++)
        //{
        //    for(int j=0;j<arr.GetLength(1);j++)
        //    {
        //        Debug.Log( i +","+ j + arr[i,j]);
        //    }
        //}


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Score()
    {

        /**********************************Player X********************************/
        if (arr[0, 0].text == "X" && arr[1, 0].text == "X" && arr[2, 0].text == "X")
        {
            PlayerCountX++;
            playerX.text =  PlayerCountX.ToString();
            reset();
        }
        if (arr[0, 1].text == "X" && arr[1, 1].text == "X" && arr[2, 1].text == "X")
        {
            PlayerCountX++;
            playerX.text = PlayerCountX.ToString();
            reset();
        }
        if (arr[0, 2].text == "X" && arr[1, 2].text == "X" && arr[2, 2].text == "X")
        {
            PlayerCountX++;
            playerX.text = PlayerCountX.ToString();
            reset();
        }
        if (arr[0, 0].text == "X" && arr[0, 1].text == "X" && arr[0, 2].text == "X")
        {
            PlayerCountX++;
            playerX.text = PlayerCountX.ToString();
            reset();
        }
        if (arr[1, 0].text == "X" && arr[1, 1].text == "X" && arr[1, 2].text == "X")
        {
            PlayerCountX++;
            playerX.text = PlayerCountX.ToString();
            reset();
        }
        if (arr[2, 0].text == "X" && arr[2, 1].text == "X" && arr[2, 2].text == "X")
        {
            PlayerCountX++;
            playerX.text = PlayerCountX.ToString();
            reset();
        }
        if (arr[0, 0].text == "X" && arr[1, 1].text == "X" && arr[2, 2].text == "X")
        {
            PlayerCountX++;
            playerX.text = PlayerCountX.ToString();
            reset();
        }
        if (arr[0, 2].text == "X" && arr[1, 1].text == "X" && arr[2, 0].text == "X")
        {
            PlayerCountX++;
            playerX.text = PlayerCountX.ToString();
            reset();
        }

        /**********************************Player O********************************/


        if (arr[0, 0].text == "O" && arr[1, 0].text == "O" && arr[2, 0].text == "O")
        {
            PlayerCountO++;
            PlayerO.text = PlayerCountO.ToString();
            reset();
        }
        if (arr[0, 1].text == "O" && arr[1, 1].text == "O" && arr[2, 1].text == "O")
        {
            PlayerCountO++;
            PlayerO.text = PlayerCountO.ToString();
            reset();
        }
        if (arr[0, 2].text == "O" && arr[1, 2].text == "O" && arr[2, 2].text == "O")
        {
            PlayerCountO++;
            PlayerO.text = PlayerCountO.ToString();
            reset();
        }
        if (arr[0, 0].text == "O" && arr[0, 1].text == "O" && arr[0, 2].text == "O")
        {
            PlayerCountO++;
            PlayerO.text = PlayerCountO.ToString();
            reset();
        }
        if (arr[1, 0].text == "O" && arr[1, 1].text == "O" && arr[1, 2].text == "O")
        {
            PlayerCountO++;
            PlayerO.text = PlayerCountO.ToString();
            reset();
        }
        if (arr[2, 0].text == "O" && arr[2, 1].text == "O" && arr[2, 2].text == "O")
        {
            PlayerCountO++;
            PlayerO.text = PlayerCountO.ToString();
            reset();
        }
        if (arr[0, 0].text == "O" && arr[1, 1].text == "O" && arr[2, 2].text == "O")
        {
            PlayerCountO++;
            PlayerO.text = PlayerCountO.ToString();
            reset();
        }
        if (arr[0, 2].text == "O" && arr[1, 1].text == "O" && arr[2, 0].text == "O")
        {
            PlayerCountO++;
            PlayerO.text = PlayerCountO.ToString();
            reset();
        }

    }

    public void BtnTicTac(TMP_Text btntxt)
    {
        clickSound.Play();
        GetParent(btntxt);
        if (BtnO == true)
        {
            btntxt.text = "O";
            BtnO = false;
            BtnX = true;
            Score();
        }
        else if (BtnX == true)
        {
            btntxt.text = "X";
            BtnX = false;
            BtnO = true;
            Score();
        }

    }

    public void GetParent(TMP_Text btntxt)
    {
        GameObject btnParent = btntxt.gameObject.transform.parent.gameObject;
        Button btn = btnParent.GetComponent<Button>();
        Btns.Add(btn);
        btn.interactable = false;
    }

    public void ResetClick()
    {
        reset();
    }

    public void NewGameClick()
    {
        SceneManager.LoadScene(0);
    }

    public void reset()
    {
        foreach (TMP_Text iter in TicTacBtns)
        {
            iter.text = " ";
        }

        foreach(Button iter in Btns)
        {
            iter.interactable = true;
        }
    }


}
