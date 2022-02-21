using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class checkEach : MonoBehaviour
{
    public InputField[] fillOut;
    public int[] emptyNum;
  public GameObject Score;
  public GameObject GameBack;
 
  void Start ()
  {
    
      GameTime.StartTimer();
  }
    void Update()
    {
        if(check1(fillOut,emptyNum)&& check2(fillOut,emptyNum) && check3(fillOut,emptyNum) && check4(fillOut,emptyNum) && check5(fillOut,emptyNum)&& check6(fillOut,emptyNum) && check7(fillOut,emptyNum) && check8(fillOut,emptyNum) && check9(fillOut,emptyNum))
            GameBack.SetActive(false);
        Score.SetActive(true);
    
        

        
    }
    bool check1(InputField[] fillOut,int[] emptyNum)
    {
        if (fillOut[0].text == emptyNum[0].ToString() &&fillOut[1].text == emptyNum[1].ToString() &&fillOut[2].text == emptyNum[2].ToString() &&fillOut[3].text == emptyNum[3].ToString() &&fillOut[4].text == emptyNum[4].ToString() &&fillOut[5].text == emptyNum[5].ToString() &&fillOut[6].text == emptyNum[6].ToString() &&fillOut[7].text == emptyNum[7].ToString() &&fillOut[8].text == emptyNum[8].ToString())
            {
            
                return true;
            }
        
            return false;
        }
    bool check2(InputField[] fillOut,int[] emptyNum)
    {
        if (fillOut[9].text == emptyNum[9].ToString() &&fillOut[10].text == emptyNum[10].ToString() &&fillOut[11].text == emptyNum[11].ToString() &&fillOut[12].text == emptyNum[12].ToString() &&fillOut[13].text == emptyNum[13].ToString() &&fillOut[14].text == emptyNum[14].ToString() &&fillOut[15].text == emptyNum[15].ToString() &&fillOut[16].text == emptyNum[16].ToString() &&fillOut[17].text == emptyNum[17].ToString())
        {
            
            return true;
        }
        
        return false;
    }
    bool check3(InputField[] fillOut,int[] emptyNum)
    {
        if (fillOut[18].text == emptyNum[18].ToString() &&fillOut[19].text == emptyNum[19].ToString() &&fillOut[20].text == emptyNum[20].ToString() &&fillOut[21].text == emptyNum[21].ToString() &&fillOut[22].text == emptyNum[22].ToString() &&fillOut[23].text == emptyNum[23].ToString() &&fillOut[24].text == emptyNum[24].ToString() &&fillOut[25].text == emptyNum[25].ToString() &&fillOut[26].text == emptyNum[26].ToString() )
        {
            
            return true;
        }
        
        return false;
    }
    bool check4(InputField[] fillOut,int[] emptyNum)
    {
        if (fillOut[27].text == emptyNum[27].ToString() &&fillOut[28].text == emptyNum[28].ToString() &&fillOut[29].text == emptyNum[29].ToString() &&fillOut[30].text == emptyNum[30].ToString() &&fillOut[31].text == emptyNum[31].ToString() &&fillOut[32].text == emptyNum[32].ToString() &&fillOut[33].text == emptyNum[33].ToString() &&fillOut[34].text == emptyNum[34].ToString() &&fillOut[35].text == emptyNum[35].ToString())
        {
            
            return true;
        }
        
        return false;
    }
    bool check5(InputField[] fillOut,int[] emptyNum)
    {
        if (fillOut[36].text == emptyNum[36].ToString() &&fillOut[37].text == emptyNum[37].ToString() &&fillOut[38].text == emptyNum[38].ToString() &&fillOut[39].text == emptyNum[39].ToString() &&fillOut[40].text == emptyNum[40].ToString() &&fillOut[41].text == emptyNum[41].ToString() &&fillOut[42].text == emptyNum[42].ToString() &&fillOut[43].text == emptyNum[43].ToString() &&fillOut[44].text == emptyNum[44].ToString() )
        {
            
            return true;
        }
        
        return false;
    }
    bool check6(InputField[] fillOut,int[] emptyNum)
    {
        if (fillOut[45].text == emptyNum[45].ToString() &&fillOut[46].text == emptyNum[46].ToString() &&fillOut[47].text == emptyNum[47].ToString() &&fillOut[48].text == emptyNum[48].ToString() &&fillOut[49].text == emptyNum[49].ToString() &&fillOut[50].text == emptyNum[50].ToString() &&fillOut[51].text == emptyNum[51].ToString() &&fillOut[52].text == emptyNum[52].ToString() &&fillOut[53].text == emptyNum[53].ToString())
        {
            
            return true;
        }
        
        return false;
    }
    bool check7(InputField[] fillOut,int[] emptyNum)
    {
        if (fillOut[54].text == emptyNum[54].ToString() &&fillOut[55].text == emptyNum[55].ToString() &&fillOut[56].text == emptyNum[56].ToString() &&fillOut[57].text == emptyNum[57].ToString() &&fillOut[58].text == emptyNum[58].ToString() &&fillOut[59].text == emptyNum[59].ToString() &&fillOut[60].text == emptyNum[60].ToString() &&fillOut[61].text == emptyNum[61].ToString() &&fillOut[62].text == emptyNum[62].ToString())
        {
            
            return true;
        }
        
        return false;
    }
    bool check8(InputField[] fillOut,int[] emptyNum)
    {
        if (fillOut[63].text == emptyNum[63].ToString() &&fillOut[64].text == emptyNum[64].ToString() &&fillOut[65].text == emptyNum[65].ToString() &&fillOut[66].text == emptyNum[66].ToString() &&fillOut[67].text == emptyNum[67].ToString() &&fillOut[68].text == emptyNum[68].ToString() &&fillOut[69].text == emptyNum[69].ToString() &&fillOut[70].text == emptyNum[70].ToString() &&fillOut[71].text == emptyNum[71].ToString())
        {
            
            return true;
        }
        
        return false;
    }
    bool check9(InputField[] fillOut,int[] emptyNum)
    {
        if (fillOut[72].text == emptyNum[72].ToString() &&fillOut[73].text == emptyNum[73].ToString() &&fillOut[74].text == emptyNum[74].ToString() &&fillOut[75].text == emptyNum[75].ToString() &&fillOut[76].text == emptyNum[76].ToString() &&fillOut[77].text == emptyNum[77].ToString() &&fillOut[78].text == emptyNum[78].ToString() &&fillOut[79].text == emptyNum[79].ToString() &&fillOut[80].text == emptyNum[80].ToString())
        {
            
            return true;
        }
        
        return false;
    }
    

}

