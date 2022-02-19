using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class checkEach : MonoBehaviour
{
    public InputField[] fillOut;
 //   public InputField A2;
 //  public InputField A3;
 //  public InputField A5;   
 //  public InputField A6;
 //  public InputField A7;
 //  public InputField A9;
 //  public InputField B1;
 //  public InputField B3;
 //  public InputField B4;
 //  public InputField B7;
 //  public InputField B9;
 //  public InputField C1;
 //  public InputField C6;
 // public  InputField C7;
 //  public InputField C8;
 //  public InputField D2;
 //   public InputField D4;
 //  public InputField D5;
 //  public InputField D7;
 //  public InputField E1;
 //  public InputField E3;
 //  public InputField E9;
 //  public InputField F4;
 //  public InputField F5;
 //  public InputField F6;
 //  public InputField F7;
 //  public InputField F9;
 //  public InputField G1;
 //  public InputField G2;
 //  public InputField G4;
 //  public InputField G5;
 // public  InputField G7;
 //  public InputField G8;
 //  public InputField H6;
 //  public InputField H9;
 //  public InputField I1;
 //  public InputField I2;
 //  public InputField I4;
 //  public InputField I7;
 //  public InputField I8;
 //  public InputField I9;
  public GameObject img;
  void Start ()
  {
      GameTime.StartTimer();
  }
    void Update()
    {
        if (checkA2() && checkA3() && checkA5() && checkA6() && checkA7() && checkA9() && checkB1() && checkB3() && checkB4() && checkB7() && checkB9() && checkC1() && checkC6() && checkC7() && checkC8() && checkD2() && checkD4() && checkD5() && checkD7() && checkE1() && checkE3() && checkE9() && checkF4() && checkF5() && checkF6() && checkF7() && checkF9() && checkG1() && checkG2() && checkG4() && checkG5() && checkG7() && checkG8() && checkH6() && checkH9() && checkI1() && checkI2() && checkI4() && checkI7() && checkI8() && checkI9())
        {
            img.gameObject.SetActive(true);
            Debug.Log("y");
        }
    }
    bool checkA2()
    {
        if (fillOut[0].text == "2")
        {
        
            return true;
        }

        return false;
    }
    bool checkA3()
    {
        if (fillOut[1].text == "7")
        {
            return true;
        }

        return false;
    }
    bool checkA5()
    {
        if (fillOut[2].text == "5")
        {
            return true;
        }

        return false;
    }
    bool checkA6()
    {
        if (fillOut[3].text == "4")
        {
            return true;
        }

        return false;
    }
    bool checkA7()
    {
        if (fillOut[4].text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkA9()
    {
        if (fillOut[5].text == "6")
        {
            return true;
        }

        return false;
    }
    bool checkB1()
    {
        if (fillOut[6].text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkB3()
    {
        if (fillOut[7].text == "5")
        {
            return true;
        }

        return false;
    }
    bool checkB4()
    {
        if (fillOut[8].text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkB7()
    {
        if (fillOut[9].text == "1")
        {
            return true;
        }

        return false;
    }
    bool checkB9()
    {
        if (fillOut[10].text == "8")
        {
            return true;
        }

        return false;
    }
    bool checkC1()
    {
        if (fillOut[11].text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkC6()
    {
        if (fillOut[12].text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkC7()
    {
        if (fillOut[13].text == "7")
        {
            return true;
        }

        return false;
    }
    bool checkC8()
    {
        if (fillOut[14].text == "5")
        {
            return true;
        }

        return false;
    }
    bool checkD2()
    {
        if (fillOut[15].text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkD4()
    {
        if (fillOut[16].text == "4")
        {
            return true;
        }

        return false;
    }
    bool checkD5()
    {
        if (fillOut[17].text == "6")
        {
            return true;
        }

        return false;
    }
    bool checkD7()
    {
        if (fillOut[18].text == "2")
        {
            return true;
        }

        return false;
    }
    bool checkE1()
    {
        if (fillOut[19].text == "4")
        {
            return true;
        }

        return false;
    }
    bool checkE3()
    {
        if (fillOut[20].text == "2")
        {
            return true;
        }

        return false;
    }
    bool checkE9()
    {
        if (fillOut[21].text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkF4()
    {
        if (fillOut[22].text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkF5()
    {
        if (fillOut[23].text == "7")
        {
            return true;
        }

        return false;
    }
    bool checkF6()
    {
        if (fillOut[24].text == "2")
        {
            return true;
        }

        return false;
    }
    bool checkF7()
    {
        if (fillOut[25].text == "4")
        {
            return true;
        }

        return false;
    }
    bool checkF9()
    {
        if (fillOut[26].text == "5")
        {
            return true;
        }

        return false;
    }
    bool checkG1()
    {
        if (fillOut[27].text == "7")
        {
            return true;
        }

        return false;
    }
    bool checkG2()
    {
        if (fillOut[28].text == "8")
        {
            return true;
        }

        return false;
    }
    bool checkG4()
    {
        if (fillOut[29].text == "2")
        {
            return true;
        }

        return false;
    }
    bool checkG5()
    {
        if (fillOut[30].text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkG7()
    {
        if (fillOut[31].text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkG8()
    {
        if (fillOut[32].text == "1")
        {
            return true;
        }

        return false;
    }
    bool checkH6()
    {
        if (fillOut[33].text == "6")
        {
            return true;
        }

        return false;
    }
    bool checkH9()
    {
        if (fillOut[34].text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkI1()
    {
        if (fillOut[35].text == "2")
        {
            return true;
        }

        return false;
    }
    bool checkI2()
    {
        if (fillOut[36].text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkI4()
    {
        if (fillOut[37].text == "8")
        {
            return true;
        }

        return false;
    }
    bool checkI7()
    {
        if (fillOut[38].text == "5")
        {
            return true;
        }

        return false;
    }
    bool checkI8()
    {
        if (fillOut[39].text == "6")
        {
            return true;
        }

        return false;
    }
    bool checkI9()
    {
        if (fillOut[40].text == "7")
        {
            return true;
        }

        return false;
    }
}
